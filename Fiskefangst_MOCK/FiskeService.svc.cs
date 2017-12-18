using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace Fiskefangst_MOCK
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FiskeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FiskeService.svc or FiskeService.svc.cs at the Solution Explorer and start debugging.
    public class FiskeService : IFiskeService
    {
        #region Connection string
        //Data Source=natascha.database.windows.net;Initial Catalog=School;Integrated Security=False;User ID=nataschajakobsen;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        private static string connectingString =
               "Server=tcp:natascha.database.windows.net,1433;Initial Catalog=School;Persist Security Info=False;User ID=nataschajakobsen;Password=Roskilde4000;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        #endregion

        #region STATIC LIST AF CATCH
        public static List<Catch> ListOfCatches { get; } = new List<Catch>
        {
            new Catch {Name = "Ny Fangst", Species = "Hornfisk", Weight = 20, Place = "KBH", Week = 3},

        };
        #endregion

        #region POST U. DBO (VIRKER)
        public Catch AddCatch(Catch newCatch)
        {
            //const string postCatch = "insert into Catch (Name, Species, Weight, Place, Week) values (@Name, @Species, @Weight, @Place, @Week)";

            //using (SqlConnection conn = new SqlConnection(connectingString))
            //{

            //    conn.Open();
            //    using (SqlCommand insertcmd = new SqlCommand(postCatch, conn))
            //    {
            //        insertcmd.Parameters.AddWithValue("@Name", newCatch);
            //        insertcmd.Parameters.AddWithValue("@Species", newCatch);
            //        insertcmd.Parameters.AddWithValue("@Weight", newCatch);
            //        insertcmd.Parameters.AddWithValue("@Place", newCatch);
            //        insertcmd.Parameters.AddWithValue("@Week", newCatch);
            //    }
            //}

            //return newCatch;
            ListOfCatches.Add(newCatch);
            return newCatch;
        }
        #endregion

        #region DELETE U. DBO (VIRKER)
        public Catch DeleteCatch(string id)
        {
            int fisk = int.Parse(id);
            Catch fangst = ListOfCatches.Find(te => te.Id == fisk);
            if (fangst == null) return null;
            ListOfCatches.Remove(fangst);
            return fangst;
        }
        #endregion

        #region GET U. DBO (VIRKER)
        public IList<Catch> GetCatches()
        {
            List<Catch> data = ListOfCatches;
            return ListOfCatches;
        }
        #endregion

        #region UPDATE U. DBO (VIRKER IKKE ENDNU)
        public Catch UpdateCatch(string id, Catch name)
        {
            int fisk = int.Parse(id);
            Catch livingCatch = ListOfCatches.FirstOrDefault(fi => fi.Id == fisk);
            if (livingCatch == null) return null;
            if (name.Name != null) livingCatch.Name = name.Name;
            return livingCatch;
        }
        #endregion

        #region GET DBO (Virker pls uncomment)
        //public IList<Catch> GetCatches()
        //{
        //    const string sqlstring = "SELECT * from dbo.Catch order by Week";
        //    List<Catch> liste = new List<Catch>();


        //    using (SqlConnection conn = new SqlConnection(connectingString))
        //    {
        //        conn.Open();
        //        //using (var sqlCommand = new SqlCommand(sqlstring, conn))
        //        //{
        //        //    using (var reader = sqlCommand.ExecuteReader())
        //        //    {
        //        //        List<Catch> liste = new List<Catch>();
        //        //        while (reader.Read())
        //        //        {
        //        //            var _Catch = ReadCatch(reader);
        //        //            liste.Add(_Catch);
        //        //        }
        //        //        return liste;
        //        //    }
        //        //}

        //        SqlCommand command = new SqlCommand(sqlstring, conn);
        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Catch nycatch = new Catch();

        //            nycatch.Id = reader.GetInt32(0);
        //            nycatch.Name = reader.GetString(1);
        //            nycatch.Species = reader.GetString(2);
        //            nycatch.Weight = reader.GetInt32(3);
        //            nycatch.Place = reader.GetString(4);
        //            nycatch.Week = reader.GetInt32(5);

        //            liste.Add(nycatch);
        //        }

        //    }
        //    return liste;
        //}
        #endregion

        #region GET BY ID
        public Catch GetOneCatch(string id)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
