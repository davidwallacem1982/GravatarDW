using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        //https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57
        [TestCategory("Gravatar Tests")]
        [TestMethod(displayName:"Should Validate Gravatar Extension")]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("a@a", false)]
        [DataRow("d@david.com", false)]
        [DataRow("davidwallacem@hotmail.com", true)]
        //[DataRow("https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57")]
        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = "https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57";

            Assert.AreEqual((email.ToGravatar() == result), status);
        }
    }
}
