using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common
{
    public class OwnerParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
            //get
            //{
            //    return _pageSize;
            //}
            //set
            //{
            //    _pageSize = (value > maxPageSize) ? maxPageSize : value;
            //}
        }
    }
}
