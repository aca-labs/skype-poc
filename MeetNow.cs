using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Extensibility;

public class Startup
{
	public async Task<object> Invoke(string uri)
	{
		try
        {
        	List<string> participantUri = new List<string>();
			participantUri.Add(uri);

            LyncClient.GetAutomation().BeginStartConversation(
			    AutomationModalities.Video,
			    participantUri,
			    null,
			    (ar) =>
			    {
			        ConversationWindow newWindow = LyncClient.GetAutomation().EndStartConversation(ar);
			    },
			    null);
         
            return "yay";
        }
        catch (ClientNotFoundException ex)
        {
            return ex;
        }
	}
}