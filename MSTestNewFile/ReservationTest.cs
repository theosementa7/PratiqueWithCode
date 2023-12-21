using EvaluationSampleCode;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MSTestNewFile;

[TestClass]
public class ReservationTest
{

    [TestMethod]
    public void Test_CanBeCancelledBy_returnTrue()
    {
        var user = new User();
        user.IsAdmin = true;

        var reservation = new Reservation(user);
        var result = reservation.CanBeCancelledBy(user);

        Assert.IsTrue(result);
    }
}


