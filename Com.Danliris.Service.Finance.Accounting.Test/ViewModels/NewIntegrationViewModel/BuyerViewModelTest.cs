﻿
using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Danliris.Service.Finance.Accounting.Test.ViewModels.NewIntegrationViewModel
{
   
    public class BuyerViewModelTest
    {
        [Fact]
        public void Should_Succes_Instantiate_BuyerViewModel()
        {
            string id= "id test";
            string nama =  "name test";
            string code = "name test";
            string address = "address test";

            BuyerViewModel bvm = new BuyerViewModel();
            bvm.Id = id;
            bvm.Name = nama;
            bvm.Code = code;
            bvm.Address = address;

            Assert.Equal(id, bvm.Id);
            Assert.Equal(nama, bvm.Name);
            Assert.Equal(code, bvm.Code);
            Assert.Equal(address, bvm.Address);

        }

        [Fact]
        public void Should_Succes_Instantiate_NewBuyerViewModel()
        {
            int id = 1;
            string nama = "name test";
            string code = "code test";
            string address = "address test";

            NewBuyerViewModel nbvm = new NewBuyerViewModel();

            nbvm.Id = 1;
            nbvm.Name = nama;
            nbvm.Code = code;
            nbvm.Address = address;

            Assert.Equal(id, nbvm.Id);
            Assert.Equal(nama, nbvm.Name);
            Assert.Equal(code, nbvm.Code);
            Assert.Equal(address, nbvm.Address);

        }
    }
}
