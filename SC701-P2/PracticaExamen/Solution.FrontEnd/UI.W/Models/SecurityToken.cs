﻿using System;
using System.Collections.Generic;



namespace UI.W.Models
{
    public partial class SecurityToken
    {
        public int SecurityTokenId { get; set; }
        public Guid Token { get; set; }
        public int ActualId { get; set; }
    }
}
