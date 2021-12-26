using System;

class Program
{
    static void Main()
    {
        Handler thirdShift = new Handler(22, 7, null);
        Handler secondShift = new Handler(14, 23, thirdShift);
        Handler firstShift = new Handler(6, 15, secondShift);
        thirdShift.NextHandler = firstShift;

        string data = "reguest";
        string response;

        if(DateTime.Now.Hour >= 7 || DateTime.Now.Hour < 15)
        {
            response = firstShift.HandleRequest(data);
        }
        else if(DateTime.Now.Hour >= 15 || DateTime.Now.Hour < 23)
        {
            response = secondShift.HandleRequest(data);
        }
        else
        {
            response = thirdShift.HandleRequest(data);
        }

        Console.WriteLine(response);
    }
}

class Handler
{
    private Handler next;
    private int startHour;
    private int finishHour;

    public Handler NextHandler
    {
        set
        {
            next = value;
        }
    }

    public Handler(int startHour, int finishHour, Handler nextHandler)
    {
        this.startHour = startHour;
        if(startHour < 0 || startHour > 23)
        {
            this.startHour = 6;
        }
        this.finishHour = finishHour;
        if(finishHour < 0 || finishHour > 23)
        {
            this.finishHour = 15;
        }
        next = nextHandler;
    }

    public string HandleRequest(string data)
    {
        if (DateTime.Now.Hour >= this.startHour && DateTime.Now.Hour < this.finishHour - 1)
            return $"Request handled by the shift that works from {this.startHour} till {this.finishHour}.";
        else if (next != null)
        {
            return "Request was handed to the next shift.\r\n" + next.HandleRequest(data);
        }
        return "Next handler unspecified. Request not handled.";
    }
}


