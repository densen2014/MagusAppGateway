﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MagusAppGateway.Models.Dtos
{
    public class RolesDto
    {
        [Display(Name = "编号")]
        public string Id { get; set; }

        [Display(Name = "角色名称")]
        public string RoleName { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
