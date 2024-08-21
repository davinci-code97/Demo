using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    public ColorByEnum ColorByEnum;
    public MeshRenderer MeshRenderer;
    public ColorEnum ColorEnum;
    public DynamicJoystick Joystick;
    public Vector2 Direction;
    public Rigidbody Rigidbody;
    private float speed;

    public void OnInit() {
        MeshRenderer.material = ColorEnum.GetMaterialByEnum(ColorByEnum);
    }

    private void Update() {
        if (Joystick == null) return;
        Direction = Joystick.Direction;

        Rigidbody.velocity = Direction * Time.deltaTime * speed;
    }

    private void OnTriggerEnter(Collider other) {
        CollideWithPlatformBrick(other);
    }

    public virtual void Move() {

    }

    private void CollideWithPlatformBrick(Collider other) {
        // xu ly va cham voi gach tren platform
    }

    public bool IsGoingUp() => Joystick.Direction.y > 0;
    public bool IsGoingDown() => Joystick.Direction.y < 0;
}
