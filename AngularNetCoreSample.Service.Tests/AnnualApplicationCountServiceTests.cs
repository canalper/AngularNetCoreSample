using AngularNetCoreSample.Repository.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using AngularNetCoreSample.Data;
using System.Collections.Generic;
using System.Linq;

namespace AngularNetCoreSample.Repository.Tests
{
    [TestClass]
    public class AnnualApplicationCountServiceTests
    {
        private IAnnualApplicationCountRepository AnnualApplicationCountRepository;

        public AnnualApplicationCountServiceTests()
        {
            var AnnualApplicationAccountList = new List<AnnualApplicationCount>
            {
                new AnnualApplicationCount {Id=1,Year=2020,ApplyCount=4000 },
                new AnnualApplicationCount {Id=2,Year=2019,ApplyCount=5000 },
                new AnnualApplicationCount {Id=3,Year=2018,ApplyCount=3500 }
            };

            var annualApplicationCountRepository = new Mock<IAnnualApplicationCountRepository>();

            annualApplicationCountRepository.Setup(mr => mr.GetByID(It.IsAny<int>())).Returns((int i) => AnnualApplicationAccountList.Single(x => x.Id == i));

            this.AnnualApplicationCountRepository = annualApplicationCountRepository.Object;
        }

        [TestMethod]
        public void GetById_Than_Check_Correct_Object_Test()
        {
            //Arrange
            var actual = new AnnualApplicationCount { Id = 1, Year = 2020, ApplyCount = 4000 };

            //Act
            var expected = this.AnnualApplicationCountRepository.GetByID(2);

            //Assert
            Assert.AreEqual(actual.Id, expected.Id); // test correct object found
        }

        //[TestCleanup]
        //public void Cleanup()
        //{
        //    AnnualApplicationCountRepository = null;
        //}
    }
}
