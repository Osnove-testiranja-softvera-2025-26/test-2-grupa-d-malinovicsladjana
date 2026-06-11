using GymApp.Models;
using GymApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Fakes
{
    public class FakeTrainingService : ITrainingService
    {
        public List<Training> Lista { get; set; }
        public List<Training> GetTrainingsInTheLastMonth(Guid trainerId)
        {
            return Lista;
        }
    }
}
