using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanicSurvival;
public class PredictorService
{
    public bool CanSurvive(Passenger passenger)
    {
        // Placeholder: Use the ML model to predict survival here.
        bool isSurvived = (passenger.Age < 10 && passenger.Sex == "female") || (passenger.TicketClass == 1 && passenger.Age < 30); // Temporary logic

        return isSurvived;
    }
}

public class Passenger
{

    public int Age { get; set; }


    public string Sex { get; set; } = string.Empty;


    public int TicketClass { get; set; }
}