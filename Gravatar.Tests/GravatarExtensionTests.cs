using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        //https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57
        [TestCategory("Gravatar Tests")]
        [TestMethod(displayName:"Should Validate Gravatar Extension")]
        [DataRow(null, 200, false)]
        [DataRow("", 200, false)]
        [DataRow(" ", 200, false)]
        [DataRow("a@a", 200, false)]
        [DataRow("d@david.com", 200, false)]
        [DataRow("davidwallacem@hotmail.com", null, true)]
        [DataRow("davidwallacem@hotmail.com", 200, true)]
        //[DataRow("https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57")]
        public void ShouldValidateGravatar(string email, int? size, bool status)
        {
            var imagemSize = size.HasValue ? size.Value : 50;
            var result = $"https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57?s={imagemSize}";

            Assert.AreEqual((email.ToGravatar(size ?? 50) == result), status);
        }
    }
}
