﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DataMid
{
    [ServiceContract]
    public interface MiniClientServerInt
    {
        //For recieveing client to obtain the job sent by the serving client
        [OperationContract]
        string getJob(int clientId);

        //For recieving client to return completed task to the serving client once done
        [OperationContract]
        bool completeJob(int clientId, int jobSucceed, string jobResult);
    }
}
