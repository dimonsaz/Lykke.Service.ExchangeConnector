// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using Microsoft.Rest;
using Newtonsoft.Json;

namespace Lykke.ExternalExchangesApi.Exchanges.BitMex.AutorestClient.Models
{
    /// <summary>
    /// Raw Order and Balance Data
    /// </summary>
    public partial class Execution
    {
        /// <summary>
        /// Initializes a new instance of the Execution class.
        /// </summary>
        public Execution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Execution class.
        /// </summary>
        public Execution(string execID, string orderID = default(string), string clOrdID = default(string), string clOrdLinkID = default(string), double? account = default(double?), string symbol = default(string), string side = default(string), double? lastQty = default(double?), double? lastPx = default(double?), double? underlyingLastPx = default(double?), string lastMkt = default(string), string lastLiquidityInd = default(string), double? simpleOrderQty = default(double?), double? orderQty = default(double?), double? price = default(double?), double? displayQty = default(double?), double? stopPx = default(double?), double? pegOffsetValue = default(double?), string pegPriceType = default(string), string currency = default(string), string settlCurrency = default(string), string execType = default(string), string ordType = default(string), string timeInForce = default(string), string execInst = default(string), string contingencyType = default(string), string exDestination = default(string), string ordStatus = default(string), string triggered = default(string), bool? workingIndicator = default(bool?), string ordRejReason = default(string), double? simpleLeavesQty = default(double?), double? leavesQty = default(double?), double? simpleCumQty = default(double?), double? cumQty = default(double?), double? avgPx = default(double?), double? commission = default(double?), string tradePublishIndicator = default(string), string multiLegReportingType = default(string), string text = default(string), string trdMatchID = default(string), double? execCost = default(double?), double? execComm = default(double?), double? homeNotional = default(double?), double? foreignNotional = default(double?), System.DateTime? transactTime = default(System.DateTime?), System.DateTime? timestamp = default(System.DateTime?))
        {
            ExecID = execID;
            OrderID = orderID;
            ClOrdID = clOrdID;
            ClOrdLinkID = clOrdLinkID;
            Account = account;
            Symbol = symbol;
            Side = side;
            LastQty = lastQty;
            LastPx = lastPx;
            UnderlyingLastPx = underlyingLastPx;
            LastMkt = lastMkt;
            LastLiquidityInd = lastLiquidityInd;
            SimpleOrderQty = simpleOrderQty;
            OrderQty = orderQty;
            Price = price;
            DisplayQty = displayQty;
            StopPx = stopPx;
            PegOffsetValue = pegOffsetValue;
            PegPriceType = pegPriceType;
            Currency = currency;
            SettlCurrency = settlCurrency;
            ExecType = execType;
            OrdType = ordType;
            TimeInForce = timeInForce;
            ExecInst = execInst;
            ContingencyType = contingencyType;
            ExDestination = exDestination;
            OrdStatus = ordStatus;
            Triggered = triggered;
            WorkingIndicator = workingIndicator;
            OrdRejReason = ordRejReason;
            SimpleLeavesQty = simpleLeavesQty;
            LeavesQty = leavesQty;
            SimpleCumQty = simpleCumQty;
            CumQty = cumQty;
            AvgPx = avgPx;
            Commission = commission;
            TradePublishIndicator = tradePublishIndicator;
            MultiLegReportingType = multiLegReportingType;
            Text = text;
            TrdMatchID = trdMatchID;
            ExecCost = execCost;
            ExecComm = execComm;
            HomeNotional = homeNotional;
            ForeignNotional = foreignNotional;
            TransactTime = transactTime;
            Timestamp = timestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "execID")]
        public string ExecID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderID")]
        public string OrderID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clOrdID")]
        public string ClOrdID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clOrdLinkID")]
        public string ClOrdLinkID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public double? Account { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "side")]
        public string Side { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastQty")]
        public double? LastQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastPx")]
        public double? LastPx { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "underlyingLastPx")]
        public double? UnderlyingLastPx { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastMkt")]
        public string LastMkt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastLiquidityInd")]
        public string LastLiquidityInd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "simpleOrderQty")]
        public double? SimpleOrderQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderQty")]
        public double? OrderQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public double? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayQty")]
        public double? DisplayQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stopPx")]
        public double? StopPx { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pegOffsetValue")]
        public double? PegOffsetValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pegPriceType")]
        public string PegPriceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "settlCurrency")]
        public string SettlCurrency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "execType")]
        public string ExecType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ordType")]
        public string OrdType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeInForce")]
        public string TimeInForce { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "execInst")]
        public string ExecInst { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contingencyType")]
        public string ContingencyType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exDestination")]
        public string ExDestination { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ordStatus")]
        public string OrdStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggered")]
        public string Triggered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workingIndicator")]
        public bool? WorkingIndicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ordRejReason")]
        public string OrdRejReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "simpleLeavesQty")]
        public double? SimpleLeavesQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leavesQty")]
        public double? LeavesQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "simpleCumQty")]
        public double? SimpleCumQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cumQty")]
        public double? CumQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "avgPx")]
        public double? AvgPx { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commission")]
        public double? Commission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tradePublishIndicator")]
        public string TradePublishIndicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiLegReportingType")]
        public string MultiLegReportingType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trdMatchID")]
        public string TrdMatchID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "execCost")]
        public double? ExecCost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "execComm")]
        public double? ExecComm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "homeNotional")]
        public double? HomeNotional { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "foreignNotional")]
        public double? ForeignNotional { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactTime")]
        public System.DateTime? TransactTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExecID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExecID");
            }
        }
    }
}
