﻿// Copyright (c) 2019 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using JuliusSweetland.OptiKey.Enums;
using JuliusSweetland.OptiKey.Extensions;
using NUnit.Framework;

namespace JuliusSweetland.OptiKey.UnitTests.Extensions
{
    [TestFixture]
    public class KeyDownStatesExtensionsTests
    {
        [Test]
        public void TestIsDownOrLockedDown()
        {
            Assert.AreEqual(true, KeyDownStates.Down.IsDownOrLockedDown());
            Assert.AreEqual(true, KeyDownStates.LockedDown.IsDownOrLockedDown());
            Assert.AreEqual(false, KeyDownStates.Up.IsDownOrLockedDown());
        }


    }
}
