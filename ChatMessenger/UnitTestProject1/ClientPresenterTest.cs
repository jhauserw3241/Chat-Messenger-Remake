using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit;
using NUnit.Framework;
using ChatMessenger;

namespace ClientTests
{
    public class BaseClientPresenterCreated
    {
        protected ClientPresenter Presenter;
        protected ClientView View;
        protected ClientViewModel ViewModel;

        [SetUp]
        public void SetUp()
        {
            Init();
            BuildMocks();
            StubMethods();

            Presenter = new ClientPresenter(
                ViewModel,
                View
                );
        }

        protected void BuildMocks()
        {
        }

        protected void Init()
        {
            View = new ClientView();
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
        public void view_model_should_set_list_of_contacts_to_empty_list()
        {
            Assert.IsEmpty(ViewModel.Contacts);
        }

        [TestCase]
        public void view_model_should_set_list_of_conversations_to_empty_list()
        {
            Assert.IsEmpty(ViewModel.Conversations);
        }
    }
}
