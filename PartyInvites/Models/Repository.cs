using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponce> responces = new List<GuestResponce>();
        public static IEnumerable<GuestResponce> Responces => responces;

        public static void AddResponse(GuestResponce responce)
        {
            responces.Add(responce);
        }
    }
}
