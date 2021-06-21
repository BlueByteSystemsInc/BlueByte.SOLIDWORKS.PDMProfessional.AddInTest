using System;
using EPDM.Interop.epdm;

namespace BlueByte.SOLIDWORKS.PDMProfessional.AddInTest
{
    #region start up 
    class AddInTest
    {
        [STAThread]
        static void Main(string[] args)
        {
            var foo = new TestClass();
            foo.Run();
            Console.ReadLine();
        }
    }

    #endregion 
   
    // todo: 
    // Change bluebyte to be your sandbox vault 
    // change T to the addin class that implements IEdmAddIn5 
    [TestVault(Name ="bluebyte")]
    public class TestClass : TestableAddInBase<T>
    {

        /// <summary>
        /// This methods fires the <seealso cref="IEdmAddIn5.GetAddInInfo(ref EdmAddInInfo, IEdmVault5, IEdmCmdMgr5)"/> of <see cref="TestableAddInBase{T}.AddInObject"/>.
        /// </summary>
        public override void Startup()
        {
            base.Startup();
        }

        [PDMTestMethod()]
        public void Test()
        {

        }
    }

}
