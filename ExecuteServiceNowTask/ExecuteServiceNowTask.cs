using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Dts.Runtime;
// Public key 7994f6b55bd3778a
[DtsTask(DisplayName = "ExecuteServiceNowTask",
         Description = "A task to make Incident in ServiceNow")]
    public class ExecuteServiceNowTask: Task
    {
    private string _serverName;
    private string _packageCatalog = "SSISDB";
    private string _packageFolder;
    private string _packageProject;
    private string _packageName; 

    public string ServerName
    {
        set { _serverName = value; }
        get { return _serverName; }
    }

    public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
    {
    }

    public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
    {
        return DTSExecResult.Success;
//        return base.Validate(connections, variableDispenser, componentEvents, log);
    }
    public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
    {
        return DTSExecResult.Success;
        //return base.Execute(connections, variableDispenser, componentEvents, log, transaction);
    }

}
