﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.ProductImages
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
