﻿namespace MagusAppGateway.Models.Dtos
{
    public class ClientGrantTypeDto
    {
        public int? Id { get; set; }

        public string GrantType { get; set; }

        public int ClientId { get; set; }
    }
}
