using IceCoffee.Common.Extensions;
using LSTY.Sdtd.PatronsMod.Internal;
using LSTY.Sdtd.PatronsMod.WebApi.Models;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSTY.Sdtd.PatronsMod.WebApi.Modules
{
    public class ExtensionFunctionsModule : ApiModuleBase
    {
        public ExtensionFunctionsModule() : base("/ExtensionFunctions")
        {
            #region DeathPenalty
            HttpGet("/RetrieveDeathPenaltyConfig", "RetrieveDeathPenaltyConfig", _ =>
            {
                var function = FunctionManager.ExtensionFunctions.DeathPenalty;
                var data = new DeathPenaltyConfigViewModel()
                {
                    FunctionName = function.FunctionName,
                    IsEnabled = function.IsEnabled,
                    DeductPoints = function.DeductPoints,
                    DeductPointsTips = function.DeductPointsTips,
                    AllowNegative = function.AllowNegative
                };

                return SucceededResult(data);
            });

            HttpPost("/UpdateDeathPenaltyConfig", "UpdateDeathPenaltyConfig", _ =>
            {
                var data = this.Bind<DeathPenaltyConfigViewModel>();
                var function = FunctionManager.ExtensionFunctions.DeathPenalty;
                function.IsEnabled = data.IsEnabled;
                function.DeductPoints = data.DeductPoints;
                function.DeductPointsTips = data.DeductPointsTips;
                function.AllowNegative = data.AllowNegative;

                ConfigManager.Save(FunctionManager.ExtensionFunctions);

                return SucceededResult();
            });

            HttpGet("/RetrieveAvailableVariables_DeathPenalty", "RetrieveAvailableVariables_DeathPenalty", _ =>
            {
                return SucceededResult(FunctionManager.ExtensionFunctions.DeathPenalty.AvailableVariables);
            });
            #endregion

            #region OnlineReward
            HttpGet("/RetrieveOnlineRewardConfig", "RetrieveOnlineRewardConfig", _ =>
            {
                var function = FunctionManager.ExtensionFunctions.OnlineReward;
                var data = new OnlineRewardConfigViewModel()
                {
                    FunctionName = function.FunctionName,
                    IsEnabled = function.IsEnabled,
                   RewardInterval = function.RewardInterval,
                   RewardPoints = function.RewardPoints,
                   RewardPointsTips = function.RewardPointsTips
                };

                return SucceededResult(data);
            });

            HttpPost("/UpdateOnlineRewardConfig", "UpdateOnlineRewardConfig", _ =>
            {
                var data = this.Bind<OnlineRewardConfigViewModel>();
                var function = FunctionManager.ExtensionFunctions.OnlineReward;
                function.IsEnabled = data.IsEnabled;
                function.RewardInterval = data.RewardInterval;
                function.RewardPoints = data.RewardPoints;
                function.RewardPointsTips = data.RewardPointsTips;
                
                ConfigManager.Save(FunctionManager.ExtensionFunctions);

                return SucceededResult();
            });

            HttpGet("/RetrieveAvailableVariables_OnlineReward", "RetrieveAvailableVariables_OnlineReward", _ =>
            {
                return SucceededResult(FunctionManager.ExtensionFunctions.OnlineReward.AvailableVariables);
            });
            #endregion

            #region AutoRestart
            HttpGet("/RetrieveAutoRestartConfig", "RetrieveAutoRestartConfig", _ =>
            {
                var function = FunctionManager.ExtensionFunctions.AutoRestart;
                var data = new AutoRestartConfigViewModel()
                {
                    FunctionName = function.FunctionName,
                    IsEnabled = function.IsEnabled,
                    Delay = function.Delay,
                    GlobalTips = function.GlobalTips,
                    Hours = function.Hours,
                    Minutes = function.Minutes
                };

                return SucceededResult(data);
            });

            HttpPost("/UpdateAutoRestartConfig", "UpdateAutoRestartConfig", _ =>
            {
                var data = this.Bind<AutoRestartConfigViewModel>();
                var function = FunctionManager.ExtensionFunctions.AutoRestart;
                function.IsEnabled = data.IsEnabled;
                function.Delay = data.Delay;
                function.GlobalTips = data.GlobalTips;
                function.Hours = data.Hours;
                function.Minutes = data.Minutes;

                ConfigManager.Save(FunctionManager.ExtensionFunctions);

                return SucceededResult();
            });

            HttpGet("/RetrieveAvailableVariables_AutoRestart", "RetrieveAvailableVariables_AutoRestart", _ =>
            {
                return SucceededResult(FunctionManager.ExtensionFunctions.AutoRestart.AvailableVariables);
            });
            #endregion

            #region ZombieKillReward
            //HttpGet("/RetrieveZombieKillRewardConfig", "RetrieveZombieKillRewardConfig", _ =>
            //{
            //    var function = FunctionManager.ExtensionFunctions.ZombieKillReward;
            //    var data = new ZombieKillRewardConfigViewModel()
            //    {
            //        FunctionName = function.FunctionName,
            //        IsEnabled = function.IsEnabled,
            //        RewardPoints = function.RewardPoints,
            //        RewardPointsTips = function.RewardPointsTips,
            //        TriggerRequiredCount = function.TriggerRequiredCount
            //    };

            //    return SucceededResult(data);
            //});

            //HttpPost("/UpdateZombieKillRewardConfig", "UpdateZombieKillRewardConfig", _ =>
            //{
            //    var data = this.Bind<ZombieKillRewardConfigViewModel>();
            //    var function = FunctionManager.ExtensionFunctions.ZombieKillReward;
            //    function.IsEnabled = data.IsEnabled;
            //    function.RewardPoints = data.RewardPoints;
            //    function.RewardPointsTips = data.RewardPointsTips;
            //    function.TriggerRequiredCount = data.TriggerRequiredCount;

            //    ConfigManager.Save(FunctionManager.ExtensionFunctions);

            //    return SucceededResult();
            //});

            //HttpGet("/RetrieveAvailableVariables", "RetrieveAvailableVariables_ZombieKillReward", _ =>
            //{
            //    return SucceededResult(FunctionManager.ExtensionFunctions.ZombieKillReward.AvailableVariables);
            //});
            #endregion
        }
    }
}
