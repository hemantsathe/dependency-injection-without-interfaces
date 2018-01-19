using System.Threading.Tasks;

namespace WithoutInterfaces
{
    public class Storage
    {
        private readonly Logger _logger;

        public Storage(Logger logger)
        {
            _logger = logger;
        }

        public virtual async Task Save()
        {
            _logger.Log("Writing to a database here...\n");
            await Task.Delay(100);
        }
    }
}