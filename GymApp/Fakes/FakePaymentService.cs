using GymApp.Models;
using GymApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Fakes
{
    public class FakePaymentService : IPaymentService
    {
        public List<Guid> Trainer { get; set; }
        public List<BonusPayment>Payment { get; set; }

        public void UpdateTrainerBonusPayment(Guid trianerId, BonusPayment payment)
        {
            Trainer.Add(trianerId);
            Payment.Add(payment);
        }
    }
}
