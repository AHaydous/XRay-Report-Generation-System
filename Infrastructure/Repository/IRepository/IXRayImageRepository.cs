﻿using Domain.Models;
using Infrastructure.Repository.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.IRepository
{
    public interface IXRayImageRepository : IRepository<XRayImage>
    {
        Task<XRayImage> UploadXRayImage(XRayImage xRayImage);
    }
}
