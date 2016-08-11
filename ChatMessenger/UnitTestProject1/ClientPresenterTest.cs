using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit;
using NUnit.Framework;
using ChatMessenger;

namespace ClientTests
{
    public class BaseClientPresenterCreated
    {
        protected ClientViewModel ViewModel;
        protected ClientPresenter Presenter;

        [SetUp]
        public void SetUp()
        {
            Init();
            BuildMocks();
            StubMethods();

            Presenter = new ClientPresenter(
                ViewModel,
                new ClientView()
                );
        }

        protected void BuildMocks()
        {
        }

        protected void Init()
        {
            ViewModel = new ClientViewModel();
        }

        protected void StubMethods()
        {
        }
    }

    [TestFixture]
    public class WhenPresenterIsCreated : BaseClientPresenterCreated
    {
        [TestCase]
        public void set_view_model_to_null()
        {
            Assert.IsNull(Presenter._viewModel);
        }
    }
}
