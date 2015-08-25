﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class RecurringTask  : ClarizenEntity
    { /*Root*/

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Phase")]
        public string Phase { get; set; }

        [JsonProperty("StartDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("DueDate")]
        public DateTime DueDate { get; set; }

        [JsonProperty("Duration")]
        public Duration Duration { get; set; }

        [JsonProperty("ActualStartDate")]
        public DateTime ActualStartDate { get; set; }

        [JsonProperty("ActualEndDate")]
        public DateTime ActualEndDate { get; set; }

        [JsonProperty("TrackStatus")]
        public string TrackStatus { get; set; }

        [JsonProperty("Conflicts")]
        public long Conflicts { get; set; }

        [JsonProperty("OnCriticalPath")]
        public bool OnCriticalPath { get; set; }

        [JsonProperty("DurationManuallySet")]
        public bool DurationManuallySet { get; set; }

        [JsonProperty("TrackStatusManuallySet")]
        public bool TrackStatusManuallySet { get; set; }

        [JsonProperty("EarliestStartDate")]
        public DateTime EarliestStartDate { get; set; }

        [JsonProperty("LatestStartDate")]
        public DateTime LatestStartDate { get; set; }

        [JsonProperty("EarliestEndDate")]
        public DateTime EarliestEndDate { get; set; }

        [JsonProperty("LatestEndDate")]
        public DateTime LatestEndDate { get; set; }

        [JsonProperty("ExpectedProgress")]
        public double ExpectedProgress { get; set; }

        [JsonProperty("SchedulingType")]
        public string SchedulingType { get; set; }

        [JsonProperty("ImportedFrom")]
        public string ImportedFrom { get; set; }

        [JsonProperty("Importance")]
        public string Importance { get; set; }

        [JsonProperty("Priority")]
        public int Priority { get; set; }

        [JsonProperty("PercentCompleted")]
        public double PercentCompleted { get; set; }

        [JsonProperty("Manager")]
        public string Manager { get; set; }

        [JsonProperty("ChargedTypeManuallySet")]
        public bool ChargedTypeManuallySet { get; set; }

        [JsonProperty("ChildrenCount")]
        public int ChildrenCount { get; set; }

        [JsonProperty("SuccessorsCount")]
        public int SuccessorsCount { get; set; }

        [JsonProperty("PredecessorsCount")]
        public int PredecessorsCount { get; set; }

        [JsonProperty("AllResourcesCount")]
        public int AllResourcesCount { get; set; }

        [JsonProperty("AttachmentsCount")]
        public int AttachmentsCount { get; set; }

        [JsonProperty("PostsCount")]
        public int PostsCount { get; set; }

        [JsonProperty("NotesCount")]
        public int NotesCount { get; set; }

        [JsonProperty("Reportable")]
        public bool Reportable { get; set; }

        [JsonProperty("ReportableManuallySet")]
        public bool ReportableManuallySet { get; set; }

        [JsonProperty("Billable")]
        public bool Billable { get; set; }

        [JsonProperty("ChildShortcutCount")]
        public int ChildShortcutCount { get; set; }

        [JsonProperty("Project")]
        public string Project { get; set; }

        [JsonProperty("WorkPolicy")]
        public string WorkPolicy { get; set; }

        [JsonProperty("CommitLevel")]
        public string CommitLevel { get; set; }

        [JsonProperty("ReportingStartDate")]
        public DateTime ReportingStartDate { get; set; }

        [JsonProperty("SYSID")]
        public string SYSID { get; set; }

        [JsonProperty("Work")]
        public Work Work { get; set; }

        [JsonProperty("ActualEffort")]
        public ActualEffort ActualEffort { get; set; }

        [JsonProperty("RemainingEffort")]
        public RemainingEffort RemainingEffort { get; set; }

        [JsonProperty("WorkManuallySet")]
        public bool WorkManuallySet { get; set; }

        [JsonProperty("RemainingEffortManuallySet")]
        public bool RemainingEffortManuallySet { get; set; }

        [JsonProperty("WorkVariance")]
        public WorkVariance WorkVariance { get; set; }

        [JsonProperty("ActualDuration")]
        public ActualDuration ActualDuration { get; set; }

        [JsonProperty("StartDateVariance")]
        public StartDateVariance StartDateVariance { get; set; }

        [JsonProperty("ActualCost")]
        public ActualCost ActualCost { get; set; }

        [JsonProperty("DueDateVariance")]
        public DueDateVariance DueDateVariance { get; set; }

        [JsonProperty("PlannedBudget")]
        public PlannedBudget PlannedBudget { get; set; }

        [JsonProperty("DurationVariance")]
        public DurationVariance DurationVariance { get; set; }

        [JsonProperty("ActualCostManuallySet")]
        public bool ActualCostManuallySet { get; set; }

        [JsonProperty("PlannedBudgetManuallySet")]
        public bool PlannedBudgetManuallySet { get; set; }

        [JsonProperty("TimeTrackingEffort")]
        public TimeTrackingEffort TimeTrackingEffort { get; set; }

        [JsonProperty("TimeTrackingCost")]
        public TimeTrackingCost TimeTrackingCost { get; set; }

        [JsonProperty("FixedCost")]
        public FixedCost FixedCost { get; set; }

        [JsonProperty("FixedPrice")]
        public FixedPrice FixedPrice { get; set; }

        [JsonProperty("PercentInvested")]
        public double PercentInvested { get; set; }

        [JsonProperty("CostVariance")]
        public CostVariance CostVariance { get; set; }

        [JsonProperty("TimeTrackingBilling")]
        public TimeTrackingBilling TimeTrackingBilling { get; set; }

        [JsonProperty("EarnedValue")]
        public EarnedValue EarnedValue { get; set; }

        [JsonProperty("PlannedRevenue")]
        public PlannedRevenue PlannedRevenue { get; set; }

        [JsonProperty("CPI")]
        public double CPI { get; set; }

        [JsonProperty("ActualRevenue")]
        public ActualRevenue ActualRevenue { get; set; }

        [JsonProperty("SPI")]
        public double SPI { get; set; }

        [JsonProperty("PlannedRevenueManuallySet")]
        public bool PlannedRevenueManuallySet { get; set; }

        [JsonProperty("ActualRevenueManuallySet")]
        public bool ActualRevenueManuallySet { get; set; }

        [JsonProperty("Profitability")]
        public Profitability Profitability { get; set; }

        [JsonProperty("PercentProfitability")]
        public double PercentProfitability { get; set; }

        [JsonProperty("PlannedExpenses")]
        public PlannedExpenses PlannedExpenses { get; set; }

        [JsonProperty("DirectPlannedExpenses")]
        public DirectPlannedExpenses DirectPlannedExpenses { get; set; }

        [JsonProperty("ActualExpenses")]
        public ActualExpenses ActualExpenses { get; set; }

        [JsonProperty("DirectActualExpenses")]
        public DirectActualExpenses DirectActualExpenses { get; set; }

        [JsonProperty("ProjectedExpenses")]
        public ProjectedExpenses ProjectedExpenses { get; set; }

        [JsonProperty("DirectProjectedExpenses")]
        public DirectProjectedExpenses DirectProjectedExpenses { get; set; }

        [JsonProperty("PlannedBilledExpenses")]
        public PlannedBilledExpenses PlannedBilledExpenses { get; set; }

        [JsonProperty("DirectPlannedBilledExpenses")]
        public DirectPlannedBilledExpenses DirectPlannedBilledExpenses { get; set; }

        [JsonProperty("ActualBilledExpenses")]
        public ActualBilledExpenses ActualBilledExpenses { get; set; }

        [JsonProperty("DirectActualBilledExpenses")]
        public DirectActualBilledExpenses DirectActualBilledExpenses { get; set; }

        [JsonProperty("ProjectedBilledExpenses")]
        public ProjectedBilledExpenses ProjectedBilledExpenses { get; set; }

        [JsonProperty("DirectProjectedBilledExpenses")]
        public DirectProjectedBilledExpenses DirectProjectedBilledExpenses { get; set; }

        [JsonProperty("RevenueCurrencyType")]
        public string RevenueCurrencyType { get; set; }

        [JsonProperty("CostCurrencyType")]
        public string CostCurrencyType { get; set; }

        [JsonProperty("Pending")]
        public string Pending { get; set; }

        [JsonProperty("IssuesCount")]
        public int IssuesCount { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("AllowReportingOnSubItems")]
        public bool AllowReportingOnSubItems { get; set; }

        [JsonProperty("CommittedDate")]
        public DateTime CommittedDate { get; set; }

        [JsonProperty("ResourcesCount")]
        public int ResourcesCount { get; set; }

        [JsonProperty("EmailsCount")]
        public int EmailsCount { get; set; }

        [JsonProperty("BudgetedHours")]
        public BudgetedHours BudgetedHours { get; set; }

        [JsonProperty("CostBalance")]
        public CostBalance CostBalance { get; set; }

        [JsonProperty("BudgetStatus")]
        public string BudgetStatus { get; set; }

        [JsonProperty("RevenueBalance")]
        public RevenueBalance RevenueBalance { get; set; }

        [JsonProperty("ActualEffortUpdatedFromTimesheets")]
        public bool ActualEffortUpdatedFromTimesheets { get; set; }

        [JsonProperty("ParentProject")]
        public string ParentProject { get; set; }

        [JsonProperty("SfExternalId")]
        public string SfExternalId { get; set; }

        [JsonProperty("SfExternalName")]
        public string SfExternalName { get; set; }

        [JsonProperty("InternalId")]
        public string InternalId { get; set; }

        [JsonProperty("OrderID")]
        public string OrderID { get; set; }

        [JsonProperty("SKU")]
        public string SKU { get; set; }

        [JsonProperty("BaselineStartDate")]
        public DateTime BaselineStartDate { get; set; }

        [JsonProperty("BaselineStartDateVariance")]
        public BaselineStartDateVariance BaselineStartDateVariance { get; set; }

        [JsonProperty("BaselineDueDate")]
        public DateTime BaselineDueDate { get; set; }

        [JsonProperty("BaselineDueDateVariance")]
        public BaselineDueDateVariance BaselineDueDateVariance { get; set; }

        [JsonProperty("BaselineDuration")]
        public BaselineDuration BaselineDuration { get; set; }

        [JsonProperty("BaselineDurationVariance")]
        public BaselineDurationVariance BaselineDurationVariance { get; set; }

        [JsonProperty("BaselineWork")]
        public BaselineWork BaselineWork { get; set; }

        [JsonProperty("BaselineWorkVariance")]
        public BaselineWorkVariance BaselineWorkVariance { get; set; }

        [JsonProperty("BaselineCost")]
        public BaselineCost BaselineCost { get; set; }

        [JsonProperty("BaselineCostsVariance")]
        public BaselineCostsVariance BaselineCostsVariance { get; set; }

        [JsonProperty("BaselineRevenue")]
        public BaselineRevenue BaselineRevenue { get; set; }

        [JsonProperty("BaselineRevenueVariance")]
        public BaselineRevenueVariance BaselineRevenueVariance { get; set; }

        [JsonProperty("InternalStatus")]
        public string InternalStatus { get; set; }

        [JsonProperty("Deliverable")]
        public bool Deliverable { get; set; }

        [JsonProperty("DeliverableType")]
        public string DeliverableType { get; set; }

        [JsonProperty("Executable")]
        public bool Executable { get; set; }

        [JsonProperty("Parent")]
        public string Parent { get; set; }

        [JsonProperty("PlannedAmount")]
        public PlannedAmount PlannedAmount { get; set; }

        [JsonProperty("ChargedAmount")]
        public ChargedAmount ChargedAmount { get; set; }

        [JsonProperty("TCPI")]
        public double TCPI { get; set; }

        [JsonProperty("TotalEstimatedCost")]
        public TotalEstimatedCost TotalEstimatedCost { get; set; }

        [JsonProperty("ChargedAmountManuallySet")]
        public bool ChargedAmountManuallySet { get; set; }

        [JsonProperty("RevenueEarnedValue")]
        public RevenueEarnedValue RevenueEarnedValue { get; set; }

        [JsonProperty("Charged")]
        public string Charged { get; set; }

        [JsonProperty("RPI")]
        public double RPI { get; set; }

        [JsonProperty("RTCPI")]
        public double RTCPI { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }

        [JsonProperty("CompletnessDefinition")]
        public long CompletnessDefinition { get; set; }

        [JsonProperty("TaskReportingPolicy")]
        public string TaskReportingPolicy { get; set; }

        [JsonProperty("TaskReportingPolicyManuallySet")]
        public bool TaskReportingPolicyManuallySet { get; set; }

        [JsonProperty("FloatingTask")]
        public bool FloatingTask { get; set; }

        [JsonProperty("IndividualReporting")]
        public bool IndividualReporting { get; set; }

        [JsonProperty("BaselineCreationDate")]
        public DateTime BaselineCreationDate { get; set; }

        [JsonProperty("CalculateCompletenessBasedOnEfforts")]
        public bool CalculateCompletenessBasedOnEfforts { get; set; }

        [JsonProperty("AggregatedStopwatchesCount")]
        public int AggregatedStopwatchesCount { get; set; }

        [JsonProperty("ObjectAlias")]
        public string ObjectAlias { get; set; }

        [JsonProperty("ActiveStopwatch")]
        public string ActiveStopwatch { get; set; }

        [JsonProperty("StopwatchesCount")]
        public int StopwatchesCount { get; set; }

        [JsonProperty("LikesCount")]
        public int LikesCount { get; set; }

        [JsonProperty("BudgetedHoursManuallySet")]
        public bool BudgetedHoursManuallySet { get; set; }

        [JsonProperty("CurrencyEAC")]
        public CurrencyEAC CurrencyEAC { get; set; }

        [JsonProperty("CurrencyREAC")]
        public CurrencyREAC CurrencyREAC { get; set; }

        [JsonProperty("PendingTimeTrackingEffort")]
        public PendingTimeTrackingEffort PendingTimeTrackingEffort { get; set; }

        [JsonProperty("CurrencyETC")]
        public CurrencyETC CurrencyETC { get; set; }

        [JsonProperty("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("CurrencyRETC")]
        public CurrencyRETC CurrencyRETC { get; set; }

        [JsonProperty("SetByLeveling")]
        public long SetByLeveling { get; set; }

        [JsonProperty("TaskType")]
        public string TaskType { get; set; }

        [JsonProperty("Milestone")]
        public string Milestone { get; set; }

        [JsonProperty("RecurrenceType")]
        public string RecurrenceType { get; set; }

        [JsonProperty("RecurrenceInterval")]
        public int RecurrenceInterval { get; set; }

        [JsonProperty("WorkdaysOnly")]
        public bool WorkdaysOnly { get; set; }

        [JsonProperty("WeekDays")]
        public int WeekDays { get; set; }

        [JsonProperty("RecurrenceDayOfMonth")]
        public int RecurrenceDayOfMonth { get; set; }

        [JsonProperty("RecurrenceMonthOfYear")]
        public string RecurrenceMonthOfYear { get; set; }

        [JsonProperty("RecurrenceStartDate")]
        public DateTime RecurrenceStartDate { get; set; }

        [JsonProperty("RecurrenceEndDate")]
        public DateTime RecurrenceEndDate { get; set; }

        [JsonProperty("OccurenceDuration")]
        public OccurenceDuration OccurenceDuration { get; set; }

        [JsonProperty("Occurrences")]
        public int Occurrences { get; set; }
    }

}
