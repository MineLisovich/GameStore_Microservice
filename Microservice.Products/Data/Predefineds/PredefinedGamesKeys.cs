using Microservice.Products.Data.Entities;
using Microservice.Products.Data.Predefineds;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Products.Data.Predefineds
{
    public class PredefinedGamesKeys
    {
       GamesKeys id1 = new()
       {
                Id = 501,
                Key_game = "GHZNAZXB-ZXNHDANX-IOEJZNDG-MSHSJWUJ",
                Gamesid = 401
        };
        GamesKeys id2 = new()
        {
            Id = 502,
            Key_game = "IEUWYHDB-DKSNZMEU-XHSKDMWO-XMBADHNR",
            Gamesid = 402

        };
        GamesKeys id3 = new()
        {
            Id = 503,
            Key_game = "ZXNEYTAB-KFBSYDBF-XHSNWDAC-DNWHDDEWE",
            Gamesid = 403
        };
        GamesKeys id4 = new()
        {
            Id = 504,
            Key_game = "FJNVCDKM-KLWDEIRU-SXJNHWEG-SAJKFHJD",
            Gamesid = 404
        };
        GamesKeys id5 = new()
        {
            Id = 505,
            Key_game = "GRHUSDNM-CXJNWGVD-DJNCLKWD-WEYUXZBN",
            Gamesid = 405
        };
        GamesKeys id6 = new()
        {
            Id = 506,
            Key_game = "RTIOSDBN-REHJNMSAX-REUYBSXN-DSHJVBWE",
            Gamesid = 406
        };
        GamesKeys id7 = new()
        {
            Id = 507,
            Key_game = "REYUCBXN-YUEWVSBA-SAHJWVBQ-OXZIQVWB",
            Gamesid = 407
        };
       GamesKeys id8 = new()
       {
          Id = 508,
          Key_game = "VFBNYTWE-DSHJWQVB-DISUQWVB-KSJAEWBV",
          Gamesid = 408
       };
       GamesKeys id9 = new()
       {
          Id = 509,
          Key_game = "CXBNWJHE-KFJHDHJWFEK-HWEJRF-WHKFEUJ",
          Gamesid = 409
       };
       GamesKeys id10 = new()
       {
          Id = 510,
          Key_game = "WFOQEUIFHW-KWEFHJ-BEWFJH-WEFVHGJ",
          Gamesid = 410
       };
       public List<GamesKeys> _gamesKeysList;
       public PredefinedGamesKeys()
       {
            _gamesKeysList = new()
            {
              id1, id2, id3, id4, id5, id6, id7, id8, id9, id10
            };
       }
    }
}
