﻿namespace api.mapserv.utah.gov.Models
{
    public class PoBoxAddressCorrection : PoBoxAddress
    {
        public int ZipPlusFour { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public PoBoxAddressCorrection(int zip, int zip9, double x, double y) : base(zip, x, y)
        {
            ZipPlusFour = zip9;
        }
    }
}
