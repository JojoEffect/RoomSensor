using HomieNano.Version4;
using nanoFramework.TestFramework;

namespace NFUnitTest
{
    [TestClass]
    public class HomieNanoTests
    {
        [TestMethod]
        public void Device_GetTopic_Valid()
        {
            var expectedTopicId = "myTopicId";
            var device = new Device(expectedTopicId, "device", new Node[0], new string[0]);
            
            Assert.AreEqual($"{Constants.RootTopicIdentifier}{Constants.TopicSeparator}{expectedTopicId}", device.GetTopic());
        }
    }
}
