using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public Calendar calendar = new Calendar();

    private void Update()
    {
        calendar.Days++;
        Debug.Log("Days : " + calendar.Days + " / Months : " + calendar.Months + " / Years : " + calendar.Years);
    }
}

public class Calendar
{
    public int Years { get; private set; }

    private int _months;

    public int Months
    {
        get
        {
            return _months;
        }
        set
        {
            _months = value;

            if (_months > 12)
            {
                Years++;
                _months = 1;
            }
        }
    }

    private int _days;

    public int Days
    {
        get
        {
            return _days;
        }
        set
        {
            _days = value;

            if (_days > 30)
            {
                Months++;
                _days = 1;
            }
        }
    }
}