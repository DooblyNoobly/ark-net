﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArkNet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkNet.Utils.Enum;

namespace ArkNet.Service.Tests
{
    [TestClass()]
    public class DelegateServiceTests
    {
        [TestInitialize]
        public void Init()
        {
            ArkNetApi.Instance.Start(NetworkType.MainNet);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            var delegates = DelegateService.GetAll();

            Assert.IsNotNull(delegates);
        }

        [TestMethod()]
        public void GetByUsernameTest()
        {
            var dele = DelegateService.GetByUsername("arkpool");
            Assert.AreEqual(dele.Address, "ARAq9nhjCxwpWnGKDgxveAJSijNG8Y6dFQ");
        }

        [TestMethod()]
        public void GetByPubKeyTest()
        {
            var dele2 = DelegateService.GetByPubKey("022a777d6010beac8fd1092a19adacde592e9ff88b84a1106ad9bd6f32001a737a");
            Assert.AreEqual(dele2.Username,"cryptolanka123");

        }

        [TestMethod()]
        public void GetByAddressTest()
        {
            var dele = DelegateService.GetByAddress("ARAq9nhjCxwpWnGKDgxveAJSijNG8Y6dFQ");
            Assert.IsNotNull(dele);
        }

        [TestMethod()]
        public void GetVotersTest()
        {
            var dele = DelegateService.GetVoters("arkpool");

            Assert.IsNotNull(dele);
        }
    }
}