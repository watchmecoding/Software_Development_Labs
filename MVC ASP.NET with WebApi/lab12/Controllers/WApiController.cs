using lab12;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Http;
using System.Linq;
using System;
using System.Net.Http;

public class WApiController : ApiController
{
    public Database1Entities1 db = new Database1Entities1();

    [HttpGet]
    [ActionName("GetPerfumes")]
    public ICollection<Perfume> GetPerfumes()
    {
        var perfumes = db.Perfumes.ToList();
        Collection<Perfume> PL = new Collection<Perfume>();

        foreach (var p in perfumes)
        {
            PL.Add(new Perfume
            {
                PerfumeID = p.PerfumeID,
                PerfumeName = p.PerfumeName,
                TypeID = p.TypeID  
            });
        }
        return PL;
    }


    [HttpPost]
    [ActionName("CreatePerfumeANDVolume")]
    public HttpResponseMessage CreatePerfumeANDVolume(PerfumeAndVolume perfumeAndVolume)
    {
        var response = Request.CreateResponse(System.Net.HttpStatusCode.OK);
        var newPerfume = new lab12.Perfume
        {
            PerfumeName = perfumeAndVolume.Perfume.PerfumeName,
            TypeID = perfumeAndVolume.Perfume.TypeID
        };

        db.Perfumes.Add(newPerfume);
        db.SaveChanges();

        int newPerfumeID = newPerfume.PerfumeID;

        var specializationFromDB = db?.VolumeTypes?.FirstOrDefault(s => s.TypeID == perfumeAndVolume.VolumeType.VolumeID);
        
        var newSpec = new VolumeType
        {
            TypeName = specializationFromDB?.TypeName,
            PerfumeID = newPerfumeID
        };

        db.VolumeTypes.Add(newSpec);
        db.SaveChanges();

        response.Content = new StringContent("Perfume and volume created successfully.", System.Text.Encoding.UTF8, "application/json");
        return response;
    }

    [HttpPut]
    [ActionName("EditPerfumeAndVolume")]
    public HttpResponseMessage EditPerfumeAndVolume(int id, PerfumeAndVolume perfumeAndVolume)
    {
        var response = Request.CreateResponse(System.Net.HttpStatusCode.OK);

        try
        {
            var plantToUpdate = db.Perfumes.FirstOrDefault(p => p.PerfumeID == id);

            if (plantToUpdate != null)
            {
                plantToUpdate.PerfumeName = perfumeAndVolume.Perfume.PerfumeName;
                plantToUpdate.TypeID = perfumeAndVolume.Perfume.TypeID;

                var specToUpdate = db.VolumeTypes.FirstOrDefault(s => s.PerfumeID == id);

                if (specToUpdate != null)
                {
                    specToUpdate.TypeName = perfumeAndVolume.VolumeType.VolumeName;
                }

                db.SaveChanges();

                response.Content = new StringContent("Perfume and its associated Volume updated successfully.", System.Text.Encoding.UTF8, "application/json");
            }
            else
            {
                response.Content = new StringContent("Perfume with the provided ID was not found.", System.Text.Encoding.UTF8, "application/json");
            }
        }
        catch (Exception ex)
        {
            response.Content = new StringContent(ex.Message, System.Text.Encoding.UTF8, "application/json");
        }
        return response;
    }



    [HttpDelete]
    [ActionName("DeletePerfumeAndVolume")]
    public HttpResponseMessage DeletePerfumeAndVolume(int id)
    {
        var response = Request.CreateResponse(System.Net.HttpStatusCode.OK);

        try
        {
            var perfumeToDelete = db.Perfumes.FirstOrDefault(p => p.PerfumeID == id);

            if (perfumeToDelete != null)
            {
                var specToDelete = db.VolumeTypes.FirstOrDefault(s => s.PerfumeID == id);

                if (specToDelete != null)
                {
                    db.VolumeTypes.Remove(specToDelete);
                }

                db.Perfumes.Remove(perfumeToDelete);
                db.SaveChanges();

                response.Content = new StringContent("Perfume and its associated Volume deleted successfully.", System.Text.Encoding.UTF8, "application/json");
            }
            else
            {
                response.Content = new StringContent("Perfume with the provided ID was not found.", System.Text.Encoding.UTF8, "application/json");
            }
        }
        catch (Exception ex)
        {
            response.Content = new StringContent(ex.Message, System.Text.Encoding.UTF8, "application/json");
        }
        return response;
    }

    [HttpGet]
    [ActionName("GetVolume")]
    public ICollection<VolumeTypes> GetVolume(int id)
    {
        var volumes = db.VolumeTypes
                      .Where(s => s.PerfumeID == id)
                      .ToList();

        var PL = new List<VolumeTypes>();

        foreach (var volume in volumes)
        {
            PL.Add(new VolumeTypes
            {
                VolumeID = volume.TypeID,
                VolumeName = volume.TypeName,
                PerfumeID = volume.PerfumeID
            });
        }
        return PL;
    }



}

public class PerfumeAndVolume
{
    public Perfume Perfume { get; set; }
    public VolumeTypes VolumeType { get; set; }
}


public class VolumeTypes
{
    public int VolumeID { get; set; }
    public string VolumeName { get; set; }
    public Nullable<int> PerfumeID { get; set; }
}


public class Perfume
{
    public int PerfumeID { get; set; }
    public string PerfumeName { get; set; }
    public Nullable<int> TypeID { get; set; }
}