using System;
using System.Collections.Generic;
using System.Text.Json;

namespace RustAnalyzer.Models
{
    public static class PluginHooksJson
    {
        private const string JsonContent = @"[
            {
                ""HookName"": ""OnVanishReappear"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""Vanish""  
            },

            {
                ""HookName"": ""OnPlayerMuted"",
                ""HookParameters"": [""BasePlayer"",""BasePlayer"",""int"",""String""],
                ""PluginName"": ""IQChat""  
            },

            {
                ""HookName"": ""OnAdminHammerEnabled"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""AdminHammer""  
            },

            {
                ""HookName"": ""OnAdminHammerDisabled"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""AdminHammer""  
            },
            
            {
                ""HookName"": ""OnAdminAdded"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""AdminKey""  
            },

            {
                ""HookName"": ""OnAdminAdded"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""AdminKey""  
            },

            {
                ""HookName"": ""OnRealSecond"",
                ""HookParameters"": [],
                ""PluginName"": ""aTimeAPI""  
            },


            {
                ""HookName"": ""OnRustDayStarted"",
                ""HookParameters"": [],
                ""PluginName"": ""aTimeAPI""  
            },

            {
                ""HookName"": ""OnRustNightStarted"",
                ""HookParameters"": [],
                ""PluginName"": ""aTimeAPI""  
            },

            {
                ""HookName"": ""OnNewRealHourStarted"",
                ""HookParameters"": [""int""],
                ""PluginName"": ""aTimeAPI""  
            },

            {
                ""HookName"": ""OnNewRealDayStarted"",
                ""HookParameters"": [""int""],
                ""PluginName"": ""aTimeAPI""  
            },

            {
                ""HookName"": ""OnNewRealMonthStarted"",
                ""HookParameters"": [""int""],
                ""PluginName"": ""aTimeAPI""  
            },

            {
                ""HookName"": ""OnNewRealYearStarted"",
                ""HookParameters"": [""int""],
                ""PluginName"": ""aTimeAPI""  
            },


            {
                ""HookName"": ""OnModeratorSendBadWords"",
                ""HookParameters"": [""BasePlayer"",""string""],
                ""PluginName"": ""IQChat""  
            },

            {
                ""HookName"": ""OnPlayerSendBadWords"",
                ""HookParameters"": [""BasePlayer"",""string""],
                ""PluginName"": ""IQChat""  
            },

            {
                ""HookName"": ""OnHomeRemoved"",
                ""HookParameters"": [""BasePlayer"",""Vector3"",""string""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnHomeAdded"",
                ""HookParameters"": [""BasePlayer"",""Vector3"",""string""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnHomeAccepted"",
                ""HookParameters"": [""BasePlayer"",""string"",""int""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnHomeAccepted"",
                ""HookParameters"": [""BasePlayer"",""string"",""int""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnPlayerTeleported"",
                ""HookParameters"": [""BasePlayer"",""Vector3"",""Vector3""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnTeleportAccepted"",
                ""HookParameters"": [""BasePlayer"",""BasePlayer"",""int""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnTeleportRejected"",
                ""HookParameters"": [""BasePlayer"",""BasePlayer""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""CanTeleport"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""canTeleport"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnTeleportRejected"",
                ""HookParameters"": [""BasePlayer"",""BasePlayer""],
                ""PluginName"": ""IQTeleportation""  
            },

            {
                ""HookName"": ""OnPlayerTeleported"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""Vector3""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnTeleportRejected"",
                ""HookParameters"": [""BasePlayer"", ""BasePlayer""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnTeleportRequestCompleted"",
                ""HookParameters"": [""BasePlayer"", ""BasePlayer""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnTeleportAccepted"",
                ""HookParameters"": [""BasePlayer"", ""BasePlayer"", ""int""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnHomeAccepted"",
                ""HookParameters"": [""BasePlayer"", ""string"", ""int""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnHomeRemoved"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""string""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnHomeAdded"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""string""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnTeleportInterrupted"",
                ""HookParameters"": [""BasePlayer"", ""string"", ""ulong"", ""string""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""SetPermission"",
                ""HookParameters"": [""ulong"", ""string"", ""DateTime""],
                ""PluginName"": ""IQPermissions""
            },
            {
                ""HookName"": ""SetPermission"",
                ""HookParameters"": [""ulong"", ""string"", ""string""],
                ""PluginName"": ""IQPermissions""
            },
            {
                ""HookName"": ""SetGroup"",
                ""HookParameters"": [""ulong"", ""string"", ""DateTime""],
                ""PluginName"": ""IQPermissions""
            },
            {
                ""HookName"": ""SetGroup"",
                ""HookParameters"": [""ulong"", ""string"", ""string""],
                ""PluginName"": ""IQPermissions""
            },
            {
                ""HookName"": ""RevokePermission"",
                ""HookParameters"": [""ulong"", ""string""],
                ""PluginName"": ""IQPermissions""
            },
            {
                ""HookName"": ""RevokeGroup"",
                ""HookParameters"": [""ulong"", ""string"", ""DateTime""],
                ""PluginName"": ""IQPermissions""
            },
            {
                ""HookName"": ""OnKickPlayer"",
                ""HookParameters"": [""string"", ""string"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnBannedPlayerIP"",
                ""HookParameters"": [""string"", ""string"", ""double"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnBannedPlayerID"",
                ""HookParameters"": [""ulong"", ""string"", ""double"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnUpdateTimeBannedID"",
                ""HookParameters"": [""string"", ""double"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnUpdateTimeBannedIP"",
                ""HookParameters"": [""string"", ""double"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnChangePermanentBannedID"",
                ""HookParameters"": [""string"", ""double"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnChangePermanentBannedIP"",
                ""HookParameters"": [""string"", ""double"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnUnbannedID"",
                ""HookParameters"": [""string"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnUnbannedIP"",
                ""HookParameters"": [""string"", ""BasePlayer""],
                ""PluginName"": ""IQBanSystem""
            },
            {
                ""HookName"": ""OnTeleportInterrupted"",
                ""HookParameters"": [""BasePlayer"", ""string"", ""ulong"", ""string""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnHomeAdded"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""string""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnHomeRemoved"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""string""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnHomeAccepted"",
                ""HookParameters"": [""BasePlayer"", ""string"", ""int""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnTeleportAccepted"",
                ""HookParameters"": [""BasePlayer"", ""BasePlayer"", ""int""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnTeleportRequestCompleted"",
                ""HookParameters"": [""BasePlayer"", ""BasePlayer""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnTeleportRejected"",
                ""HookParameters"": [""BasePlayer"", ""BasePlayer""],
                ""PluginName"": ""NTeleportation""
            },
            {
                ""HookName"": ""OnPlayerTeleported"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""Vector3""],
                ""PluginName"": ""NTeleportation""
            },

            {
                ""HookName"": ""StartRaidBlocking"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""bool""],
                ""PluginName"": ""NoEscape""
            },
            {
                ""HookName"": ""StopBlocking"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""NoEscape""
            },
            {
                ""HookName"": ""StopRaidBlocking"",
                ""HookParameters"": [""string""],
                ""PluginName"": ""NoEscape""
            },
            {
                ""HookName"": ""StartCombatBlocking"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""NoEscape""
            },
            {
                ""HookName"": ""StopCombatBlocking"",
                ""HookParameters"": [""string""],
                ""PluginName"": ""NoEscape""
            },

            {
                ""HookName"": ""API_AddOnlinePrisoner"",
                ""HookParameters"": [""BasePlayer"", ""bool"", ""int""],
                ""PluginName"": ""XPrison""
            },
            {
                ""HookName"": ""API_RemoveOnlinePrisoner"",
                ""HookParameters"": [""BasePlayer""],
                ""PluginName"": ""XPrison""
            },
            {
                ""HookName"": ""API_AddOfflinePrisoner"",
                ""HookParameters"": [""BasePlayer"", ""bool"", ""int""],
                ""PluginName"": ""XPrison""
            },
            {
                ""HookName"": ""API_RemoveOfflinePrisoner"",
                ""HookParameters"": [""ulong""],
                ""PluginName"": ""XPrison""
            },

            {
                ""HookName"": ""OnQuestCompleted"",
                ""HookParameters"": [""BasePlayer"", ""string""],
                ""PluginName"": ""XDQuest""
            },
            {
                ""HookName"": ""OnQuestProgress"",
                ""HookParameters"": [""ulong"", ""QuestType"", ""string"", ""string"", ""List<Item>"", ""int""],
                ""PluginName"": ""XDQuest""
            },

            {
                ""HookName"": ""API_SET_BALANCE"",
                ""HookParameters"": [""string"", ""int"", ""ItemContainer""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_SET_BALANCE"",
                ""HookParameters"": [""ulong"", ""int"", ""ItemContainer""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_SET_BALANCE"",
                ""HookParameters"": [""BasePlayer"", ""int"", ""ItemContainer""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_REMOVE_BALANCE"",
                ""HookParameters"": [""string"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_REMOVE_BALANCE"",
                ""HookParameters"": [""BasePlayer"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_REMOVE_BALANCE"",
                ""HookParameters"": [""ulong"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""ulong"", ""ulong"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""BasePlayer"", ""BasePlayer"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""string"", ""string"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""ulong"", ""string"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""string"", ""ulong"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""BasePlayer"", ""ulong"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""BasePlayer"", ""string"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""ulong"", ""BasePlayer"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""API_TRANSFERS"",
                ""HookParameters"": [""string"", ""BasePlayer"", ""int""],
                ""PluginName"": ""IQEconomic""
            },
            {
                ""HookName"": ""OnTimedPermissionGranted"",
                ""HookParameters"": [""string"", ""string"", ""TimeSpan""],
                ""PluginName"": ""TimedPermissions""
            },
            {
                ""HookName"": ""OnTimedPermissionExtended"",
                ""HookParameters"": [""string"", ""string"", ""TimeSpan""],
                ""PluginName"": ""TimedPermissions""
            },
            {
                ""HookName"": ""OnTimedGroupAdded"",
                ""HookParameters"": [""string"", ""string"", ""TimeSpan""],
                ""PluginName"": ""TimedPermissions""
            },
            {
                ""HookName"": ""OnTimedGroupExtended"",
                ""HookParameters"": [""string"", ""string"", ""TimeSpan""],
                ""PluginName"": ""TimedPermissions""
            },
            {
                ""HookName"": ""SetZoneStatus"",
                ""HookParameters"": [""string"", ""bool""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""AddFlag"",
                ""HookParameters"": [""string"", ""string""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""RemoveFlag"",
                ""HookParameters"": [""string"", ""string""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""AddDisabledFlag"",
                ""HookParameters"": [""string"", ""string""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""RemoveDisabledFlag"",
                ""HookParameters"": [""string"", ""string""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""OnEnterZone"",
                ""HookParameters"": [""string"", ""BasePlayer""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""OnExitZone"",
                ""HookParameters"": [""string"", ""BasePlayer""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""OnEntityEnterZone"",
                ""HookParameters"": [""string"", ""BaseEntity""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""OnEntityExitZone"",
                ""HookParameters"": [""string"", ""BaseEntity""],
                ""PluginName"": ""ZoneManager""
            },
            {
                ""HookName"": ""GetKitNames"",
                ""HookParameters"": [""List<string>""],
                ""PluginName"": ""Kits""
            },
            {
                ""HookName"": ""SetPlayerCooldown"",
                ""HookParameters"": [""ulong"", ""string"", ""double""],
                ""PluginName"": ""Kits""
            },
            {
                ""HookName"": ""SetPlayerKitUses"",
                ""HookParameters"": [""ulong"", ""string"", ""int""],
                ""PluginName"": ""Kits""
            },
            {
                ""HookName"": ""OnBackpackOpened"",
                ""HookParameters"": [""BasePlayer"", ""ulong"", ""ItemContainer""],
                ""PluginName"": ""Backpacks""
            },
            {
                ""HookName"": ""OnBackpackClosed"",
                ""HookParameters"": [""BasePlayer"", ""ulong"", ""ItemContainer""],
                ""PluginName"": ""Backpacks""
            },
            {
                ""HookName"": ""OnRaidableBaseStarted"",
                ""HookParameters"": [""Vector3"", ""int"", ""float""],
                ""PluginName"": ""RaidableBases""
            },
            {
                ""HookName"": ""OnRaidableBaseEnded"",
                ""HookParameters"": [""Vector3"", ""int"", ""float""],
                ""PluginName"": ""RaidableBases""
            },
            {
                ""HookName"": ""OnPlayerEnteredRaidableBase"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""bool""],
                ""PluginName"": ""RaidableBases""
            },
            {
                ""HookName"": ""OnPlayerExitedRaidableBase"",
                ""HookParameters"": [""BasePlayer"", ""Vector3"", ""bool""],
                ""PluginName"": ""RaidableBases""
            },
            {
                ""HookName"": ""GetPointRaid"",
                ""HookParameters"": [""ulong"", ""ulong""],
                ""PluginName"": ""FClan""
            },
            {
                ""HookName"": ""IsFriendOf"",
                ""HookParameters"": [""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""GetFriendList"",
                ""HookParameters"": [""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""GetFriendList"",
                ""HookParameters"": [""string""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""GetFriends"",
                ""HookParameters"": [""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""GetMaxFriends"",
                ""HookParameters"": [],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""IsFriend"",
                ""HookParameters"": [""ulong"", ""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""RemoveFriend"",
                ""HookParameters"": [""ulong"", ""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""AddFriend"",
                ""HookParameters"": [""ulong"", ""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""AreFriends"",
                ""HookParameters"": [""ulong"", ""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""HasFriend"",
                ""HookParameters"": [""ulong"", ""ulong""],
                ""PluginName"": ""Friends""
            },
            {
                ""HookName"": ""OnOpenedCase"",
                ""HookParameters"": [""BasePlayer"", ""string""],
                ""PluginName"": ""IQCases""
            },
            {
                ""HookName"": ""OnBuyCase"",
                ""HookParameters"": [""BasePlayer"", ""string""],
                ""PluginName"": ""IQCases""
            },
            {
                ""HookName"": ""OnSellCase"",
                ""HookParameters"": [""BasePlayer"", ""string""],
                ""PluginName"": ""IQCases""
            },
            {
                ""HookName"": ""API_GIVE_CASE"",
                ""HookParameters"": [""ulong"", ""string"", ""int""],
                ""PluginName"": ""IQCases""
            },
            {
                ""HookName"": ""API_REMOVE_CASE"",
                ""HookParameters"": [""ulong"", ""string"", ""int""],
                ""PluginName"": ""IQCases""
            }
            
        ]";

        public static List<PluginHookModel> GetHooks()
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                
                var hooks = JsonSerializer.Deserialize<List<PluginHookModel>>(JsonContent, options);
                return hooks ?? new List<PluginHookModel>();
            }
            catch
            {
                return new List<PluginHookModel>();
            }
        }
    }
} 