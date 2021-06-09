using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Webmotors.Service
{
    public class AnunciosServices :IAnunciosServices
    {
        private readonly ILogger<AnunciosServices> _logger;

    }

    public interface IAnunciosServices
    {
    }
}
