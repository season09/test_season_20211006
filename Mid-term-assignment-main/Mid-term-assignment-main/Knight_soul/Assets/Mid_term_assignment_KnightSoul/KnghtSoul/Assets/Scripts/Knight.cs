using UnityEngine;
//�� 2021/11/7�Ĥ@����s

public class Knight : MonoBehaviour
{
    //�M�h��q,�ˮ`..���ƾ�

    #region
    
    [Header("�ƾ�") , Range( 1, 200) ]
    public int Hp = 100;
    [Range(1 , 10)]
    public int Attack = 5;
    [Range(1, 10)]
    public int Armor = 5;
    [Range(1, 10)]
    public int MoveSpeed = 5;
    [Header("�O�_�ਾ�m")]
    public bool Defense = false;

    #endregion

    //��L�ާ@

    #region

    [Header("�ާ@����")]
    public KeyCode keycode;
    public KeyCode keyCodeAttack = KeyCode.Mouse0;
    public KeyCode keyCodeMoveLeft = KeyCode.D;
    public KeyCode keyCodeMoveRight = KeyCode.A;
    public KeyCode keyCodeJump = KeyCode.Space;
    
    #endregion

}
