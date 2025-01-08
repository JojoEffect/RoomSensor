using HomieNano;
using HomieNano.Version4;
using nanoFramework.TestFramework;

namespace NFUnitTest
{
    [TestClass]
    public class HomieNanoTests
    {
        private const string _testDeviceTopicId = "super-car";
        private const string _testDeviceName = "Super car";
        //private HomieDeviceBuilder _builder = new(_testDeviceTopicId, _testDeviceName, new string[0]);

        [TestMethod]
        public void Device_GetTopic_Valid()
        {
            // Act

            // this works....
            //var builder = new HomieDeviceBuilder(_testDeviceTopicId, _testDeviceName, new string[0]);
            //var device = builder.BuildDevice();

            // this doesn't work....
            //var device = _builder.BuildDevice();
            var device = new Device(_testDeviceTopicId, _testDeviceName, new string[1]);


            var expectedTopic = CreateExpectedTopicFrom(device);

            // Assert
            Assert.AreEqual(expectedTopic, device.GetTopic());
        }

        
        
        [TestMethod]
        public void Node_GetTopic_Valid()
        {
            // Arrange
            var expectedTopicId = "engine";
            var expectedName = "Car engine";
            var expectedType = "V8";
            var builder = new HomieDeviceBuilder(_testDeviceTopicId, _testDeviceName, new string[0]);

            var device = builder
                .AddNode(expectedTopicId, expectedName, expectedType)
                .BuildNode()
                .BuildDevice();

            // Act
            var node = device.Nodes[0];
            var expectedTopic = CreateExpectedTopicFrom(device, nodeAtIndex: 0);

            // Assert
            Assert.AreEqual(expectedTopicId, node.TopicId);
            Assert.AreEqual(expectedName, node.NameAttribute.Value);
            Assert.AreEqual(expectedType, node.TypeAttribute.Value);
            Assert.AreEqual(expectedTopic, device.Nodes[0].GetTopic());
        }
        

        private string CreateExpectedTopicFrom(Device device)
        {
            return $"{Constants.RootTopicIdentifier}{Constants.TopicSeparator}{device.TopicId}";
        }

        private string CreateExpectedTopicFrom(Device device, int nodeAtIndex)
        {
            var node = device.Nodes[nodeAtIndex];
            return $"{Constants.RootTopicIdentifier}{Constants.TopicSeparator}{device.TopicId}{Constants.TopicSeparator}{node.TopicId}";
        }
    }
}
