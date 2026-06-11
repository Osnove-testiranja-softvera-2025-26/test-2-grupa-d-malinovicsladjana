using GymApp.Models;
using GymApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Fakes
{
    internal class FakeTrainerPerformanceService : ITrainerPerformanceService
    {

        private readonly PerformanceReport _performanceReport;
        private readonly bool _shouldThrow;
        public PerformanceReport GetTrainerPerformanceReport(Guid trainerId)
        {
            if(_shouldThrow)
            {
                throw new NotImplementedException();
            }
            else
                return _performanceReport;
        }
    }
}
