using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit;
using NUnit.Framework;
using ChatMessenger;

namespace ClientTests
{
    #region Setup Client Class
    public class BaseClientPresenterCreated
    {
        protected ClientPresenter Presenter;
        protected ClientView View;
        protected ClientViewModel ViewModel;

        [SetUp]
        public virtual void SetUp()
        {
            Init();
            BuildMocks();
            StubMethods();

            Presenter = new ClientPresenter(
                ViewModel,
                View
                );
        }

        protected virtual void BuildMocks()
        {
        }

        protected virtual void Init()
        {
            View = new ClientView();
            ViewModel = new ClientViewModel();
        }

        protected virtual void StubMethods()
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

    public class BaseClientPresenterIsLoaded : BaseClientPresenterCreated
    {
        [SetUp]
        public override void SetUp()
        {
            Presenter.Load();
        }
    }

    [TestFixture]
    public class WhenClientPresenterIsLoaded : BaseClientPresenterIsLoaded
    {
    }
    #endregion

    #region User Called Events
    #endregion
}
