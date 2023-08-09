using SRS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Processor
{
    public class ProcessSrsOrders
    {
        private readonly ISRSProcessor sRSProcessor;

        public ProcessSrsOrders(ISRSProcessor sRSProcessor)
        {
            this.sRSProcessor = sRSProcessor;
        }

        public async Task Process()
        {
            await sRSProcessor.RunAsync();
        }
    }
}
