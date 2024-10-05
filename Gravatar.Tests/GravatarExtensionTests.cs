using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod(displayName: "Should Validate Gravatar Extension")]
        [DataRow(null, 200, false)]
        [DataRow("", 200, false)]
        [DataRow(" ", 200, false)]
        [DataRow("a@a", 200, false)]
        [DataRow("d@david.com", 200, false)]
        [DataRow("davidwallacem@hotmail.com", null, true)]
        [DataRow("davidwallacem@hotmail.com", 200, true)]
        public void ShouldValidateGravatar(string email, int? size, bool status)
        {
            var imagemSize = size ?? 50;
            var result = email?.ToGravatar(imagemSize) ?? string.Empty;

            Assert.AreEqual(result == $"https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57?s={imagemSize}", status);
        }
    }
}
