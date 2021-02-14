using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //Tek başına tablo değil o yüzden IEntity değil . Bir kaç tablonun birleşimi olabilir o yüzden IDto
    public class ProductDetailDto: IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
