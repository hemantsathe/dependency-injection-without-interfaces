using System.Threading.Tasks;
using Moq;
using WithoutInterfaces;
using Xunit;

namespace WithoutInterfaceTests
{
    public class OrderServiceTest
    {
        [Fact]
        public async void OrderReturnsOk()
        {
            var logger = new Logger();
            var storageMock = new Mock<Storage>(logger);
            storageMock
                .Setup(s => s.Save())
                .Callback(() => logger.Log("mocked storage"))
                .Returns(Task.CompletedTask);

            var orderService = new OrderService(logger, storageMock.Object);

            var status = await orderService.Order();

            Assert.Equal(OrderStatus.Ok, status);
            Assert.Contains("ordering logic", logger.ToString());
            Assert.DoesNotContain("database", logger.ToString());
            Assert.Contains("mocked storage", logger.ToString());
        }
    }
}