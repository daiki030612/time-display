using UnityEngine;
using UnityEngine.UI; //Text���g�p����גǉ��B
using System; //DateTime���g�p����גǉ��B

public class Timetext : MonoBehaviour
{
    //�e�L�X�gUI���h���b�O&�h���b�v
    [SerializeField] Text DateTimeText;

    //DateTime���g�����ߕϐ���ݒ�
    DateTime TodayNow;

    void Update()
    {
        //���Ԃ��擾
        TodayNow = DateTime.Now;

        //�e�L�X�gUI�ɔN�E���E���E�b��\��������
        DateTimeText.text = TodayNow.Year.ToString() + "�N " + TodayNow.Month.ToString() + "��" + TodayNow.Day.ToString() + "��" + DateTime.Now.ToLongTimeString();
    }
}
using UnityEngine;
using UnityEngine.UI; //Text���g�p����גǉ��B
using System; //DateTime���g�p����גǉ��B

public class Timetext : MonoBehaviour
{
    //�e�L�X�gUI���h���b�O&�h���b�v
    [SerializeField] Text DateTimeText;

    //DateTime���g�����ߕϐ���ݒ�
    DateTime TodayNow;

    void Update()
    {
        //���Ԃ��擾
        TodayNow = DateTime.Now;

        //�e�L�X�gUI�ɔN�E���E���E�b��\��������
        DateTimeText.text = TodayNow.Year.ToString() + "�N " + TodayNow.Month.ToString() + "��" + TodayNow.Day.ToString() + "��" + DateTime.Now.ToLongTimeString();
    }
}
