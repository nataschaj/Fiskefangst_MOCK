using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Fiskefangst_MOCK
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFiskeService" in both code and config file together.
    [ServiceContract]
    public interface IFiskeService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "catch/")]
        IList<Catch> GetCatches();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "catch/{id}")]
        Catch GetOneCatch(string id);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "catch")]
        Catch AddCatch(Catch newCatch);


        [OperationContract]
        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "catch/{id}")]
        Catch UpdateCatch(string id, Catch name);

        


        [OperationContract]
        [WebInvoke(Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "catch/{id}")]
        Catch DeleteCatch(string id);


    }
}
