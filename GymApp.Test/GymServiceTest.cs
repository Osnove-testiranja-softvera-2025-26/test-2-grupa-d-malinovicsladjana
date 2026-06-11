
using Nunit.Framework
namespace GymApp.Test
{
    //Guid example: "00000000-0000-0000-0000-000000000001"

    [TestFixture]
    public class GymServiceTest
    {
        FakePaymentService _paymentService;
        FakeTrainerPerformanceService _trainerPerformanceService;
        FakeTrainingService _trainingService;
        GymService _service;

        [SetUp]
        public void SetUp
        {
            _paymentService = new FakePaymentService;
            _trainerPerformanceService = new FakeTrainerPerformanceService;
            _trainingService = new FakeTrainingService;
            _service = new GymService;
        }

    [Test]
    public DoStaffBonusPaymentCalculation_NoTrainings_Exception
        {
            List<Training> Lista = _trainingService.GetTrainingsInTheLastMonth(trainer.Id);
            Lista.Count = 0;
            string error = "Bonus payment cannot be calculated";
            var ex = Assert.Throws<NoTrainingsInTheLastMonthException>((TestDelegate)(() => _trainingService.GetTrainingsInTheLastMonth(trainer.Id)));
            Assert.That(error, Is.EqualTo(ex.Message));
        }

    }
}
