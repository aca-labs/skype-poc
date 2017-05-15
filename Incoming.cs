using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Conversation;

public class Startup
{
	public async Task<object> Invoke(Func<object,Task<object>> eventHandler)
	{
		try
        {
        	LyncClient.GetClient().ConversationManager.ConversationAdded +=
        			(Object source, ConversationManagerEventArgs e) => {
            			eventHandler("").Start();
        			};
        	return "listening";
        }
        catch (ClientNotFoundException ex)
        {
            return ex;
        }
	}
}