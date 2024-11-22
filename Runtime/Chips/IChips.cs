/*
using System.Collections.Generic;
using UnityEngine;

namespace RRCGGenerated
{
    public interface IChips
    {

        // Outputs the magnitude of the number. Is always positive.
        float AbsoluteValue(float value);

        // Outputs the magnitude of the number. Is always positive.
        int AbsoluteValue(int value);

        // Computes the arccosine of a number.
        float Acos(float value);

        // Computes the sum of two or more inputs.
        int Add(params int[] value);

        // Computes the sum of two or more inputs.
        float Add(params float[] value);

        // Computes the sum of two or more inputs.
        Vector3 Add(params Vector3[] value);

        // Adds a tag to the input object or player.
        void AddTag(Player target, string tag);

        // Adds a tag to the input object or player.
        void AddTag(RecRoomObject target, string tag);

        // Adds tags to the input object or player.
        void AddTags(Player target, List<string> tags);

        // Adds tags to the input object or player.
        void AddTags(RecRoomObject target, List<string> tags);

        // Outputs the current line of sight parameters from the input AI.
        (string VisionType, float VisionRange, float VisionConeAngle, float HearingRange) AIGetLineOfSightParametersR1(AI aI);

        // Outputs the current combat target of an inputted AI.
        Combatant AIGetTargetR1(AI aI);

        // Outputs if the input AI has line of sight to the input target.
        bool AIHasLineOfSightToTargetR1(AI aI, AI target);

        // Outputs if the input AI has line of sight to the input target.
        bool AIHasLineOfSightToTargetR1(AI aI, Combatant target);

        // Outputs if the input AI has line of sight to the input target.
        bool AIHasLineOfSightToTargetR1(AI aI, RecRoomObject target);

        // Outputs if the input AI has line of sight to the input target.
        bool AIHasLineOfSightToTargetR1(AI aI, PatrolPoint target);

        // Outputs if the input AI has line of sight to the input target.
        bool AIHasLineOfSightToTargetR1(AI aI, Player target);

        // Outputs if the input AI has line of sight to the input target.
        bool AIHasLineOfSightToTargetR1(AI aI, Vector3 target);

        // Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        void AILookAtR1(AI aI, AI lookTarget, bool lookTargetIsDirection);

        // Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        void AILookAtR1(AI aI, Combatant lookTarget, bool lookTargetIsDirection);

        // Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        void AILookAtR1(AI aI, RecRoomObject lookTarget, bool lookTargetIsDirection);

        // Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        void AILookAtR1(AI aI, PatrolPoint lookTarget, bool lookTargetIsDirection);

        // Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        void AILookAtR1(AI aI, Player lookTarget, bool lookTargetIsDirection);

        // Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        void AILookAtR1(AI aI, Vector3 lookTarget, bool lookTargetIsDirection);

        // Commands the AI to path to the input target destination.
        void AIPathToR1(AI aI, AI target);

        // Commands the AI to path to the input target destination.
        void AIPathToR1(AI aI, Combatant target);

        // Commands the AI to path to the input target destination.
        void AIPathToR1(AI aI, RecRoomObject target);

        // Commands the AI to path to the input target destination.
        void AIPathToR1(AI aI, PatrolPoint target);

        // Commands the AI to path to the input target destination.
        void AIPathToR1(AI aI, Player target);

        // Commands the AI to path to the input target destination.
        void AIPathToR1(AI aI, Vector3 target);

        // Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        void AIRotateR1(AI aI, float rotation);

        // Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        void AIRotateR1(AI aI, int rotation);

        // Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        void AIRotateR1(AI aI, Vector3 rotation);

        // Sets an AI’s various LoS paramters. The “Cone” setting acts like a vision cone that sits in front of AIs like eyes, where the “Circle” setting acts like a radius around the AI. The Require LoS For Targetting parameter defines if AIs can see you through walls.
        void AISetLineOfSightParametersR1(AI aI, string visionType, float visionRange, float visionConeAngle, float hearingRange, bool requireLoSForTargeting);

        // Sets the speed for an inputted AI. This same setting can be determined by configuring the AI itself.
        void AISetPathingSpeedR1(AI aI, float speed);

        // Set an AIs Path Point.
        void AISetPatrolPointR1(AI aI, PatrolPoint patrolPoint);

        // Sets the input AI’s current target.
        void AISetTargetR1(AI aI, Combatant target);

        // RRO Quest AI black box. This node tells the input AI to start their C# defined combat behavior. Note: this behavior varies per AI.
        void AIStartCombatBehaviorR1(AI aI);

        // Tells the input AI to stop its C# defined combat behavior.
        void AIStopCombatBehaviorR1(AI aI);

        // Command the input AI to cancel its current Rotate and Look At commands. Call this before telling an AI to path after having it Rotate/Look At so it rotates properly while moving again.
        void AIStopLookingR1(AI aI);

        // A i variable r1
        AI AIVariableR1(AI port1, VariableData config);

        // Choose from a selection of ambient audio tracks, for use with the Audio Player.
        Audio AmbienceConstant();

        // Outputs True when all inputs are True. If any input is False, it outputs False.
        bool And(params bool[] input);

        // Add angular velocity to an object. The Angular Velocity vector should lie along the axis of the rotation being added, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s. Once the new angular velocity has been computed, its speed will be capped by the Max Angular Speed.
        bool AngularVelocityAdd(RecRoomObject target, Vector3 angularVelocity, float speedMultiplier, float maxAngularSpeed);

        // Sets the angular velocity of an object. The Angular Velocity vector should lie along the axis of rotation, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s.
        bool AngularVelocitySet(RecRoomObject target, Vector3 angularVelocity, float speedMultiplier);

        // Returns the current frame of the given animation controller component.
        int AnimationGetFrame(AnimationController animator);

        // Returns whether or not the Animation Controller is currently playing.
        bool AnimationGetIsPlaying(AnimationController animator);

        // Returns the normalized speed of the given Animation Controller.
        float AnimationGetSpeed(AnimationController animator);

        // Returns the current time stamp of the given animation controller. The value is not impacted by the animation speed.
        float AnimationGetTimeStamp(AnimationController animator);

        // Pauses the Animation Controller. The Animation Controller resumes at the same moment next time play is activated.
        void AnimationPause(AnimationController animator);

        // Tells the Animation Controller to play its animation using the Playback Mode set in the Animation Controller's configuration menu.
        void AnimationPlay(AnimationController animator);

        // Sets the Animation Controller's animation to a specific frame number.
        void AnimationSetFrame(AnimationController animator, int frameNumber);

        // Sets the Animation Controller's play speed. Default value is 1. Negative values play the animation in reverse.
        void AnimationSetSpeed(AnimationController animator, float speed);

        // Sets the time stamp of the given animation controller to the given time in seconds. The time stamp is not impacted by the animation speed.
        void AnimationSetTimeStamp(AnimationController animator, float timeStamp);

        // Stops the Animation Controller. The Animation Controller restarts from the beginning next time play is activated.
        void AnimationStop(AnimationController animator);

        // Computes the arcsine of a number.
        float Asin(float value);

        // Computes the arctangent of a number.
        float Atan(float value);

        // Computes the 2-argument arctangent of a number.
        float Atan2(float y, float x);

        // Returns the intensity of the target Audio FX Zone object.
        float AudioFXZoneGetIntensity(AudioFXZone target);

        // Returns the priority of the target Audio FX Zone object.
        int AudioFXZoneGetPriority(AudioFXZone target);

        // Sets the effect of the target Audio FX Zone object.
        void AudioFXZoneSetEffect(AudioFXZone target);

        // Sets the intensity of the target Audio FX Zone object.
        void AudioFXZoneSetIntensity(AudioFXZone target, float intensity);

        // Sets the priority of the target Audio FX Zone object.
        void AudioFXZoneSetPriority(AudioFXZone target, int priority);

        // Returns the length in seconds of the given audio reference.
        float AudioGetLength(Audio audio);

        // Returns the most recent audio reference that the target Audio Player has started playing.
        Audio AudioPlayerGetAudio(AudioPlayer target);

        // Returns the furthest distance from the target Audio Player that the audio can be heard from.
        float AudioPlayerGetMaxRolloffDistance(AudioPlayer target);

        // Returns True if the target Audio Player is playing.
        bool AudioPlayerGetPlaying(AudioPlayer target);

        // Returns the speed multiplier of the target Audio Player.
        float AudioPlayerGetSpeed(AudioPlayer target);

        // Returns the current time stamp of the target Audio Player in seconds.
        float AudioPlayerGetTimeStamp(AudioPlayer target);

        // Returns the volume multiplier of the target Audio Player.
        float AudioPlayerGetVolume(AudioPlayer target);

        // Audio player pause
        void AudioPlayerPause(AudioPlayer target);

        // Audio player play
        void AudioPlayerPlay(AudioPlayer target, Audio audio);

        // Sets the maximum distance that audio from the target Audio Player can be heard from.
        void AudioPlayerSetMaxRolloffDistance(AudioPlayer target, float maxRolloffDistance);

        // Sets the speed multiplier that the target Audio Player will play at.
        void AudioPlayerSetSpeed(AudioPlayer target, float speed);

        // Sets the time stamp of the target Audio Player in seconds.
        void AudioPlayerSetTimeStamp(AudioPlayer target, float timeStamp);

        // Sets the volume multiplier that the target Audio Player will play at.
        void AudioPlayerSetVolume(AudioPlayer target, float volume);

        // Audio player stop
        void AudioPlayerStop(AudioPlayer target);

        // Award a room consumable to a player. Multiple award room consumable requests from the same client are sent in bulk with a ten-second cooldown. The Success port will be TRUE if the consumable was entirely, or in part, awarded to the player. If the consumable could not be awarded, the Success port will be FALSE. Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        bool AwardConsumableR1(Consumable consumable, Player player, int quantity, AlternativeExec<bool> onAwardConsumableComplete);

        // Award some amount to the Player's balance of one room currency. Configure this chip to set the affected currency.

        // Award some amount to the Player's balance of the given room currency.
        (bool Success, int TotalBalance) AwardCurrencyR1(RoomCurrency currency, Player player, int amount, AlternativeExec<(bool Success, int TotalBalance);

        // Unlocks a room key for the target player. Multiple award room key requests from the same client are sent in bulk with a one-second cooldown.
        // The Success port will be TRUE if the key was successfully unlocked for the player or if the player previously owned the key. If the key could not be awarded the Success port will be FALSE.
        // Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        bool AwardRoomKeyR1(RoomKey roomKey, Player player, AlternativeExec<bool> onAwardRoomKeyComplete);

        // Defines values for the room's background objects.
        BackgroundObjects BackgroundObjectsConstant();

        // Returns the color of the target Beacon object.
        Color BeaconGetColor(Beacon target);

        // Outputs True if the target Beacon object is enabled.
        bool BeaconGetEnabled(Beacon target);

        // Returns the height of the target Beacon object.
        float BeaconGetHeight(Beacon target);

        // Sets the color of the target Beacon object.
        void BeaconSetColor(Beacon target, Color color);

        // Sets the enabled state of the target Beacon object.
        void BeaconSetEnabled(Beacon target, bool enabled);

        // Sets the height of the target Beacon object.
        void BeaconSetHeight(Beacon target, float height);

        // Computes a bitwise AND. The result has a bit set for every bit that is set in both of the inputs.
        int BitAnd(int port0, int port1);

        // Counts the number of zeros at the beginning (most significant side) of the binary representation of an integer.
        int BitLeadingZeros(int value);

        // Computes a bitwise NAND. (NOT AND) The result has a bit set for every bit that is not set in either of the inputs.
        int BitNand(int port0, int port1);

        // Computes a bitwise NOT. The result has a bit set for every bit that is not set in the input.
        int BitNot(int port0);

        // Computes a bitwise OR. The result has a bit set for every bit that is set in either of the inputs.
        int BitOr(int port0, int port1);

        // Counts the number of set bits in the binary representation of an integer.
        int BitPopCount(int value);

        // Rotates digits in the binary representation of an integer to the left. As the leftmost bits fall off, they are used to fill the rightmost bits.
        int BitRotateLeft(int value, int shift);

        // Rotates digits in the binary representation of an integer to the right. As the rightmost bits fall off, they are used to fill the leftmost bits.
        int BitRotateRight(int value, int shift);

        // Shifts a value left by a number of bits. Leftmost bits are discarded, and rightmost bits are filled with zeros.
        int BitShiftLeft(int value, int shift);

        // Shifts a value right by a number of bits. Rightmost bits are discarded, and leftmost bits are filled with zeros. (Logical shift)
        int BitShiftRight(int value, int shift);

        // Counts the number of zeros at the end (least significant side) of the binary representation of an integer.
        int BitTrailingZeros(int value);

        // Computes a bitwise XOR. The result has a bit set for every bit that is set in exactly one of the inputs.
        int BitXor(int port0, int port1);

        // Reads or writes a variable in the current scope based on the name.
        bool BoolVariable(bool port1, VariableData config);

        // Outputs a target Button's Pressed property.
        bool ButtonGetIsPressed(Button target);

        // Outputs a target Button's Text property.
        string ButtonGetText(Button target);

        // Sets an input Button's Text property.
        void ButtonSetText(Button target, string text);

        // Returns the least integral value greater than or equal to the input value.
        float Ceil(float value);

        // Returns the smallest integer value greater than or equal to the input value.
        int CeilToInt(float value);

        // Use as a way to encapsulate your logic. You can have as many inputs and outputs as you like. Use the Edit tool to open up the Circuit Board and add nodes inside it to encapsulate the logic. Hit done editing on your Maker Pen to leave the Circuit Board context.
        void CircuitBoard();

        // Clamps a value between a minimum value and maximum value. If the minimum is greater than the maximum, the minimum value will always be returned no matter the input.
        float Clamp(float value, float min, float max);

        // Clamps a value between a minimum value and maximum value. If the minimum is greater than the maximum, the minimum value will always be returned no matter the input.
        int Clamp(int value, int min, int max);

        // Clears any active screen vignette on the given player.
        void ClearPlayerVignette(Player player);

        // Clear the UI configuration displayed above a given player.
        void ClearPlayerWorldUI(Player player);

        // Clear screen
        void ClearScreen(TextScreen target);

        // Gets distance in meters of an object/player from center specified in "Overlap Sphere" chip.
        float CollisionDataGetDistance(CollisionData target);

        // Gets unit vector specifying the direction of an object/player from center specified in "Overlap Sphere" chip.
        Vector3 CollisionDataGetNormal(CollisionData target);

        // Gets object of a collision data (or null for players) returned from "Overlap Sphere" chip.
        RecRoomObject CollisionDataGetObject(CollisionData target);

        // Gets player of a collision data (or null for objects) returned from "Overlap Sphere" chip.
        Player CollisionDataGetPlayer(CollisionData target);

        // Gets position of an object/player returned by "Overlap Sphere" chip.
        Vector3 CollisionDataGetPosition(CollisionData target);

        // Collision detection volume get enabled
        bool CollisionDetectionVolumeGetEnabled(CollisionDetectionVolume target);

        // Collision detection volume set enabled
        void CollisionDetectionVolumeSetEnabled(CollisionDetectionVolume target, bool enabled);

        // Color constant
        Color ColorConstant();

        // Return hue, saturation, and value from the given color.
        (float Hue, float Saturation, float Value) ColorToHSV(Color color);

        // Return red, green, and blue from the given color.
        (float Red, float Green, float Blue) ColorToRGB(Color color);

        // Reads or writes a variable in the current scope based on the name.
        Color ColorVariable(Color port1, VariableData config);

        // Outputs the ground position of an input combatant.
        Vector3 CombatantGetGroundPositionR1(AI combatant);

        // Outputs the ground position of an input combatant.
        Vector3 CombatantGetGroundPositionR1(Combatant combatant);

        // Outputs the ground position of an input combatant.
        Vector3 CombatantGetGroundPositionR1(Player combatant);

        // Outputs the Health property of the input combatant.
        (int Health, int Shield, int MaxHealth) CombatantGetHealthR1(AI @object);

        // Outputs the Health property of the input combatant.
        (int Health, int Shield, int MaxHealth) CombatantGetHealthR1(Combatant @object);

        // Outputs the Health property of the input combatant.
        (int Health, int Shield, int MaxHealth) CombatantGetHealthR1(Player @object);

        // Outputs True if the input combatant is alive.
        bool CombatantGetIsAliveR1(AI @object);

        // Outputs True if the input combatant is alive.
        bool CombatantGetIsAliveR1(Combatant @object);

        // Outputs True if the input combatant is alive.
        bool CombatantGetIsAliveR1(Player @object);

        // Outputs the input combatant's current velocity and speed.
        (Vector3 Velocity, float Speed) CombatantGetVelocityR1(AI combatant);

        // Outputs the input combatant's current velocity and speed.
        (Vector3 Velocity, float Speed) CombatantGetVelocityR1(Combatant combatant);

        // Outputs the input combatant's current velocity and speed.
        (Vector3 Velocity, float Speed) CombatantGetVelocityR1(Player combatant);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(AI target, int damage, bool ignoreShield, AI damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(AI target, int damage, bool ignoreShield, Combatant damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(AI target, int damage, bool ignoreShield, Player damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(Combatant target, int damage, bool ignoreShield, AI damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(Combatant target, int damage, bool ignoreShield, Combatant damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(Combatant target, int damage, bool ignoreShield, Player damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(Player target, int damage, bool ignoreShield, AI damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(Player target, int damage, bool ignoreShield, Combatant damageSource);

        // Deals damage to the given target combatant with various parameters.
        void CombatantReceiveDamageR1(Player target, int damage, bool ignoreShield, Player damageSource);

        // Sets the Health property of an input combatant.
        void CombatantSetHealthR1(AI target, int health);

        // Sets the Health property of an input combatant.
        void CombatantSetHealthR1(Combatant target, int health);

        // Sets the Health property of an input combatant.
        void CombatantSetHealthR1(Player target, int health);

        // Sets the Max Health property of the input combatant.
        void CombatantSetMaxHealthR1(AI target, int maxHealth);

        // Sets the Max Health property of the input combatant.
        void CombatantSetMaxHealthR1(Combatant target, int maxHealth);

        // Sets the Max Health property of the input combatant.
        void CombatantSetMaxHealthR1(Player target, int maxHealth);

        // Splits the input Combatant into Player and AI types. Use this off of Combatant outputs to directly access the Player or AI.
        (bool IsPlayer, Player Player, AI AI) CombatantSplitR1(Combatant combatant);

        // Combatant variable r1
        Combatant CombatantVariableR1(Combatant port1, VariableData config);

        // Put a comment next to your circuits to explain what they're doing.
        void Comment();

        // Community event constant
        object CommunityEventConstant();

        // Community event variable
        object CommunityEventVariable(object port1, VariableData config);

        // Sets the input consumable to active. Use this to confirm a consumable used event. Can also be used independently. Displays the consumable as active in the backback and decreases the number of comsumables the player owns.
        void ConsumableActivateR1(Consumable consumable);

        // Consumable constant r1
        Consumable ConsumableConstantR1(RoomConsumableData config);

        // Sets the input consumable to inactive. Displays the consumable as not active in the backback and allow using another one.
        void ConsumableDeactivateR1(Consumable consumable);

        // Control panel
        string ControlPanel();

        // Computes the cosine of a number.
        float Cos(float value);

        // Equip a Player with a costume.
        void CostumeEquip(Costume target, Player player);

        // Get Player wearing a costume.
        Player CostumeGetWearer(Costume target);

        // Unequip a costume.
        Player CostumeUnequip(Costume target);

        // A single data table. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room to commit changes.
        void DataTable(object port0, DataTableDefinitionData config);

        // Returns a list of row indices containing the given value within a specified Data Table. Configure the chip to select the data table and column.

        // Returns the number of columns in the given data table, set by configuring the chip.
        int DataTableGetColumnCount(DataTableData config);

        // Returns the first row containing the given value within a specified Data Table. Configure the chip to select the Data Table and column.
        int DataTableGetFirstRowContaining(DataTableColumnData config);

        // Returns the number of rows in the given data table, set by configuring the chip.
        int DataTableGetRowCount(DataTableData config);

        // Returns the value in the specified row from the specified column. Use the configuration menu to set which Data Table and Column to read from, which will also determine the output pin type.
        void DataTableReadCell(int row, DataTableColumnData config);

        // Fires outputs based on the inputted time to delay. The Run exec fires as soon as the node is executed. The After Delay exec fires once the input delay duration has completed. After Canceled fires after the delay node’s Cancel exec has been fired. Cancel cancels all current delays running from this node, except for delays scheduled for the next tick.
        void Delay(float delay, AlternativeExec afterDelay, AlternativeExec cancel);

        // Configure this constant to choose a destination, specifying room, subroom, and welcome mat. If destination room is different than current room, only Entry Subrooms may be targeted. Party follow options may vary by destination. Use this chip with Go To Room.
        DestinationRoom DestinationRoomConstant();

        // Stores a destination room. Destination cannot be configured from variable - for that, use a Constant.
        DestinationRoom DestinationRoomVariable(DestinationRoom port1, VariableData config);

        // Returns the current Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
        Vector3 DialogueUIGetBillboardingPivotOffset(DialogueUI target);

        // Returns the current text of the target Dialogue UI’s main body for the local player, and whether or not it’s currently interactive.
        (string BodyText, bool IsInteractive) DialogueUIGetDialogueText(DialogueUI target);

        // Returns whether or not the target Dialogue UI is enabled for the local player.
        bool DialogueUIGetIsEnabled(DialogueUI target);

        // Returns whether or not the target Dialogue UI’s title bar is visible for the local player.
        bool DialogueUIGetTitleIsEnabled(DialogueUI target);

        // Returns the current title of the target Dialogue UI for the local player.
        string DialogueUIGetTitleText(DialogueUI target);

        // Sets the Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
        void DialogueUISetBillboardingPivotOffset(DialogueUI target, Vector3 offset);

        // Set the visibility and text of up to four buttons on the target Dialogue UI for the local player. Text will truncate after 512 characters. Buttons are automatically interactive when enabled. Each button will fire a Button Pressed event in the Dialogue UI’s board scope when pressed. Button visibility is dependent on the Dialogue UI being enabled.
        void DialogueUISetButtonState(DialogueUI target, bool button1Enabled, string button1Text, bool button2Enabled, string button2Text, bool button3Enabled, string button3Text, bool button4Enabled, string button4Text);

        // Sets the text of the target Dialogue UI’s main body for the local player. Text will truncate after 256 characters. If “Is interactive” is true, an arrow will appear in the lower right when the text has fully animated in, and the whole panel will be clickable for the player. The Next Pressed event will fire in the Dialogue UI’s board scope when this interactive panel is clicked.
        void DialogueUISetDialogueText(DialogueUI target, string bodyText, bool isInteractive);

        // Toggles whether or not the target Dialogue UI is enabled for the local player.
        void DialogueUISetIsEnabled(DialogueUI target, bool isEnabled);

        // Toggles visibility of the target Dialogue UI’s title bar for the local player. Visibility is dependent on the Dialogue UI being enabled.
        void DialogueUISetTitleIsEnabled(DialogueUI target, bool isEnabled);

        // Sets the title field of the target Dialogue UI for the local player. Text will truncate after 48 characters.
        void DialogueUISetTitleText(DialogueUI target, string titleText);

        // Returns the player who rolled the dice.
        Player DiceGetPlayerRolled(Die target);

        // Returns the result of the dice.
        int DiceGetResult(Die target);

        // Outputs an exec when the dice finished rolling.
        bool DiceGetRollFinished(Die target);

        // Displays a target UI configuration above a given player.
        void DisplayPlayerWorldUI(PlayerWorldUI target, Player player);

        // Outputs the distance between the input objects.
        float Distance(AI a, AI b);

        // Outputs the distance between the input objects.
        float Distance(AI a, Combatant b);

        // Outputs the distance between the input objects.
        float Distance(AI a, RecRoomObject b);

        // Outputs the distance between the input objects.
        float Distance(AI a, Player b);

        // Outputs the distance between the input objects.
        float Distance(AI a, Vector3 b);

        // Outputs the distance between the input objects.
        float Distance(Combatant a, AI b);

        // Outputs the distance between the input objects.
        float Distance(Combatant a, Combatant b);

        // Outputs the distance between the input objects.
        float Distance(Combatant a, RecRoomObject b);

        // Outputs the distance between the input objects.
        float Distance(Combatant a, Player b);

        // Outputs the distance between the input objects.
        float Distance(Combatant a, Vector3 b);

        // Outputs the distance between the input objects.
        float Distance(RecRoomObject a, AI b);

        // Outputs the distance between the input objects.
        float Distance(RecRoomObject a, Combatant b);

        // Outputs the distance between the input objects.
        float Distance(RecRoomObject a, RecRoomObject b);

        // Outputs the distance between the input objects.
        float Distance(RecRoomObject a, Player b);

        // Outputs the distance between the input objects.
        float Distance(RecRoomObject a, Vector3 b);

        // Outputs the distance between the input objects.
        float Distance(Player a, AI b);

        // Outputs the distance between the input objects.
        float Distance(Player a, Combatant b);

        // Outputs the distance between the input objects.
        float Distance(Player a, RecRoomObject b);

        // Outputs the distance between the input objects.
        float Distance(Player a, Player b);

        // Outputs the distance between the input objects.
        float Distance(Player a, Vector3 b);

        // Outputs the distance between the input objects.
        float Distance(Vector3 a, AI b);

        // Outputs the distance between the input objects.
        float Distance(Vector3 a, Combatant b);

        // Outputs the distance between the input objects.
        float Distance(Vector3 a, RecRoomObject b);

        // Outputs the distance between the input objects.
        float Distance(Vector3 a, Player b);

        // Outputs the distance between the input objects.
        float Distance(Vector3 a, Vector3 b);

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Outputs the distance between the input objects.

        // Find how many times a value contains another.
        int Divide(params int[] value);

        // Find how many times a value contains another.
        float Divide(params float[] value);

        // Find how many times a value contains another.
        Vector3 Divide(params Vector3[] value);

        // Door get destination r1
        DestinationRoom DoorGetDestinationR1(RoomDoor target);

        // Door get locked r1
        bool DoorGetLockedR1(RoomDoor target);

        // Door set destination r1
        void DoorSetDestinationR1(RoomDoor target, DestinationRoom room);

        // Door set locked r1
        void DoorSetLockedR1(RoomDoor target, bool locked);

        // Returns True if the target Emitter is looping.
        bool EmitterGetLooping(Emitter target);

        // Returns True if the target Emitter is playing.
        bool EmitterGetPlaying(Emitter target);

        // Returns the size multiplier of the target Emitter.
        float EmitterGetSize(Emitter target);

        // Returns the speed multiplier of the target Emitter.
        float EmitterGetSpeed(Emitter target);

        // Sets the color for the particles emitted.
        void EmitterSetColor(Emitter target, Color color);

        // Sets the color for the particles emitted.

        // Makes the emitter emit continuously or not.
        void EmitterSetLooping(Emitter target, bool value);

        // Sets the size of the particles emitted.
        void EmitterSetSize(Emitter target, float value);

        // Sets the speed particles are emitted.
        void EmitterSetSpeed(Emitter target, float value);

        // Starts emitting particles.
        void EmitterStart(Emitter target);

        // Stops emitting particles.
        void EmitterStop(Emitter target);

        // Compares the input values and outputs True if they are the same. False if they are different.

        // Compares the two input values and outputs True if they are the same. False if they are different.

        // Display up to six interactive buttons that can access Inventory Items (Inventory Slots) or physical objects (Holster Slots.) Configure this chip to configure the settings for a slot. Output type will change based on Type setting.  Use with Player Set Equipment Slot Is Enabled and the various Player Equip chips.
        EquipmentSlot EquipmentSlotR2();

        // Equip object to dominant hand
        bool EquipObjectToDominantHand(Player player, RecRoomObject objectToEquip, bool forceEquip, bool steal);

        // Equip object to off hand
        bool EquipObjectToOffHand(Player player, RecRoomObject objectToEquip, bool forceEquip, bool steal);

        // Equips Share Camera to a player's dominant hand if the player is not already holding the Share Camera.
        // Returns success if the target player is already holding their Share Camera in either hand.
        bool EquipShareCamera(Player player, bool forceEquip);

        // Event definition
        void EventDefinition(EventDefinitionData config);

        // Events are the entry points for all circuit graphs. Events are execution hooks for things like a player loading into the room, or knowing when a Button is pressed. After creating this chip, make sure to use the configure tool to choose the event you want to listen for. You can use the Event Defintion chip to create your own events to add to this list and use with the Event Sender chip.
        void EventReceiver(EventReceiverData config);

        // Use the Event Sender to fire your custom events defined in Event Defintions. After creating this chip, make sure to use the configure tool to change the event that you want to fire. You can also change who you want to send the event to from the config menu.
        void EventSender(EventSenderData config);

        // Executes the associated output of the compare value that matches the 'match' input. Executes the default output if no match can be found.
        void ExecutionIntegerSwitch(int match);

        // Executes the associated output of the compare value that matches the 'match' input. Executes the default output if no match can be found.
        void ExecutionStringSwitch(string match);

        // Explosion emitter explode
        void ExplosionEmitterExplode(ExplosionEmitter target);

        // Explosion emitter get damage
        int ExplosionEmitterGetDamage(ExplosionEmitter target);

        // Explosion emitter get explosion color
        Color ExplosionEmitterGetExplosionColor(ExplosionEmitter target);

        // Explosion emitter get explosion radius
        float ExplosionEmitterGetExplosionRadius(ExplosionEmitter target);

        // Returns the player set by the Explosion Emitter Set Firing Player chip.
        Player ExplosionEmitterGetFiringPlayer(ExplosionEmitter target);

        // Explosion emitter set damage
        void ExplosionEmitterSetDamage(ExplosionEmitter target, int damage);

        // Explosion emitter set explosion color
        void ExplosionEmitterSetExplosionColor(ExplosionEmitter target, Color color);

        // Explosion emitter set explosion radius
        void ExplosionEmitterSetExplosionRadius(ExplosionEmitter target, float radius);

        // Sets the firing player of the target Explosion Emitter. If none is set, the component will use the authority player.
        void ExplosionEmitterSetFiringPlayer(ExplosionEmitter target, Player player);

        // Reads or writes a variable in the current scope based on the name.
        float FloatVariable(float port1, VariableData config);

        // Returns the smallest integral value less than or equal to the input value.
        float Floor(float value);

        // Returns the smallest integer value less than or equal to the input value.
        int FloorToInt(float value);

        // Defines settings for room fog.
        Fog FogConstant(FogData config);

        // Iterates over the "From" pin (inclusive) to the "To" pin (exclusive).
        int For(int from, int to, AlternativeExec<int> done);

        // Iterates over the input list. The loop exec fires for each element in the list. The Done exec fires once the end of the list has been reached.

        // Converts the input Rec Room Object to the object's subtype.

        // Defines a function.
        void FunctionDefinition();

        // Function out
        void FunctionOut();

        // Game h u d element constant
        HUDElement GameHUDElementConstant();

        // Returns a list with all the inventory items in this room.

        // Returns a List of Room Inventory Items that are tagged with the inputted tag.

        // Outputs a list of all the players in the room currently.

        // Outputs a list of all the players in the room currently.

        // Outpus List<Player> that continues every player with the specified role.

        // Returns the angular velocity in degrees per second of a Rec Room Object.
        Vector3 GetAngularVelocity(RecRoomObject target);

        // Gets a player with the role. Returns invalid player if no player has the role.
        Player GetAnyPlayerWithRoleR1(string role);

        // Gets the authority player of the chip's current context.
        Player GetAuthority();

        // Outputs player counts if you're in an event that's actively broadcasting.
        (int AudienceCount, int BroadcasterCount, bool IsBroadcastActive) GetBroadcastingAttendance();

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject origin, List<RecRoomObject> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Player Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject origin, List<Player> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject origin, List<Vector3> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(Player origin, List<RecRoomObject> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Player Closest, int ClosestIndex, float Distance) GetClosest(Player origin, List<Player> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(Player origin, List<Vector3> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(Vector3 origin, List<RecRoomObject> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Player Closest, int ClosestIndex, float Distance) GetClosest(Vector3 origin, List<Player> targets);

        // Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(Vector3 origin, List<Vector3> targets);

        // Returns the local players balance of one room currency. Configure this chip to selecht which currency to use.

        // Returns the given player's balance of the given room currency.
        (bool Success, int TotalBalance) GetCurrencyBalanceR1(RoomCurrency currency, Player player, AlternativeExec<(bool Success, int TotalBalance);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject origin, List<RecRoomObject> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Player Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject origin, List<Player> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject origin, List<Vector3> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(Player origin, List<RecRoomObject> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Player Farthest, int FarthestIndex, float Distance) GetFarthest(Player origin, List<Player> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(Player origin, List<Vector3> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 origin, List<RecRoomObject> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Player Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 origin, List<Player> targets);

        // Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 origin, List<Vector3> targets);

        // Gets the first tag of an object or player.
        string GetFirstTag(Player target);

        // Gets the first tag of an object or player.
        string GetFirstTag(RecRoomObject target);

        // Returns the given universal time, formatted based on the C# DateTime format specifiers.
        string GetFormattedTime(float universalSeconds, string format);

        // Returns the given universal time, formatted based on the C# DateTime format specifiers.
        string GetFormattedTime(int universalSeconds, string format);

        // Gets the forward direction of a target, output as a vector.
        Vector3 GetForwardVector(RecRoomObject target);

        // Gets the forward direction of a target, output as a vector.
        Vector3 GetForwardVector(Player target);

        // Gets the forward direction of a target, output as a vector.

        // Gets the forward direction of a target, output as a vector.

        // Get h u d element color
        Color GetHUDElementColor(HUDConstant target);

        // Returns true if the local player has a HUD element of the given type currently enabled.
        bool GetHUDElementEnabled(HUDConstant target);

        // Get h u d element label
        string GetHUDElementLabel(HUDConstant target);

        // Get h u d element max value
        int GetHUDElementMaxValue(HUDConstant target);

        // Get h u d element value
        int GetHUDElementValue(HUDConstant target);

        // Gets the Inventory Item that matches the provided friendly name
        InventoryItem GetInventoryItemFromNameR2(string name);

        // Returns the number of players that are currently loading into the room.
        int GetLoadingPlayers();

        // Gets the direction your avatar is looking, output as a Vector3.
        Vector3 GetLocalCameraForward();

        // Gets the position of your avatar's view, output as a Vector3.
        Vector3 GetLocalCameraPosition();

        // Gets the rotation of your avatar's view, output as a quaternion.
        Quaternion GetLocalCameraRotation();

        // Gets the up direction from the local player's camera, output as a Vector3.
        Vector3 GetLocalCameraUp();

        // Outputs the player running this chip on their machine.
        Player GetLocalPlayer();

        // Returns a new line string.
        string GetNewLine();

        // Returns the party of the input player as List<Player>. If the player is not in a party, it will return a list containing only that player.

        // Outputs the player's Account name (e.g Coach) in a form of a string. To get a display name, use To String.
        string GetPlayerAccountName(Player player);

        // Gets a Player based on an Account Name. (E.g. my account name is @Coach and if I input the string "Coach", the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given account name.
        Player GetPlayerByAccountName(string name);

        // Gets a Player based on a display name. (E.g. my display name is Coach and if I input a string "Coach", the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given display name.
        Player GetPlayerByDisplayName(string name);

        // Returns the enabled state of the given player's world UI.
        bool GetPlayerWorldUIEnabled(Player target);

        // Returns the color of the given player's primary bar in their current world UI.
        Color GetPlayerWorldUIPrimaryBarColor(Player target);

        // Returns the enabled state of the given player's primary bar in their current world UI.
        bool GetPlayerWorldUIPrimaryBarEnabled(Player target);

        // Returns the max value of the given player's primary bar in their current world UI.
        int GetPlayerWorldUIPrimaryBarMaxValue(Player target);

        // Returns the value of the given player's primary bar in their current world UI.
        int GetPlayerWorldUIPrimaryBarValue(Player target);

        // Returns the color of the given player's secondary bar in their current world UI.
        Color GetPlayerWorldUISecondaryBarColor(Player target);

        // Returns the enabled state of the given player's secondary bar in their current world UI.
        bool GetPlayerWorldUISecondaryBarEnabled(Player target);

        // Returns the max value of the given player's secondary bar in their current world UI.
        int GetPlayerWorldUISecondaryBarMaxValue(Player target);

        // Returns the value of the given player's secondary bar in their current world UI.
        int GetPlayerWorldUISecondaryBarValue(Player target);

        // Returns the color of the given player's text in their current world UI.
        Color GetPlayerWorldUITextColor(Player target);

        // Returns the enabled state of the given player's text in their current world UI.
        bool GetPlayerWorldUITextEnabled(Player target);

        // Returns the value of the given player's text in their current world UI.
        string GetPlayerWorldUITextValue(Player target);

        // Outputs the position of the input object as a vector3.
        Vector3 GetPosition(AI target);

        // Outputs the position of the input object as a vector3.
        Vector3 GetPosition(Combatant target);

        // Outputs the position of the input object as a vector3.
        Vector3 GetPosition(RecRoomObject target);

        // Outputs the position of the input object as a vector3.
        Vector3 GetPosition(Player target);

        // Outputs the position of the input object as a vector3.

        // Outputs the position of the input object as a vector3.

        // Outputs the position of the input object as a vector3.

        // Outputs the position of the input object as a vector3.

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(AI target, AI referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(AI target, Combatant referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(AI target, RecRoomObject referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(AI target, Player referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Combatant target, AI referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Combatant target, Combatant referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Combatant target, RecRoomObject referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Combatant target, Player referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, AI referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, Combatant referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, RecRoomObject referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, Player referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Player target, AI referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Player target, Combatant referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Player target, RecRoomObject referenceObject);

        // Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        Vector3 GetPositionInReferenceObjectSpace(Player target, Player referenceObject);

        // Returns the player who is the room authority.
        Player GetRoomAuthority();

        // Outputs the rotation of the target as a quaternion.
        Quaternion GetRotation(RecRoomObject target);

        // Outputs the rotation of the target as a quaternion.
        Quaternion GetRotation(Player target);

        // Outputs the rotation of the target as a quaternion.

        // Outputs the rotation of the target as a quaternion.

        // Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        Quaternion GetRotationInReferenceObjectSpace(RecRoomObject target, RecRoomObject referenceObject);

        // Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        Quaternion GetRotationInReferenceObjectSpace(RecRoomObject target, Player referenceObject);

        // Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        Quaternion GetRotationInReferenceObjectSpace(Player target, RecRoomObject referenceObject);

        // Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        Quaternion GetRotationInReferenceObjectSpace(Player target, Player referenceObject);

        // Outputs a list of tags the input object or player has.

        // Outputs a list of tags the input object or player has.

        // Outputs the up direction of the input target, output as a vector3.
        Vector3 GetUpVector(RecRoomObject target);

        // Outputs the up direction of the input target, output as a vector3.
        Vector3 GetUpVector(Player target);

        // Outputs the up direction of the input target, output as a vector3.

        // Outputs the up direction of the input target, output as a vector3.

        // Returns the velocity of a Player or a Rec Room Object.
        Vector3 GetVelocity(RecRoomObject target);

        // Returns the velocity of a Player or a Rec Room Object.
        Vector3 GetVelocity(Player target);

        // Returns the velocity of a Player or a Rec Room Object.

        // Returns the velocity of a Player or a Rec Room Object.

        // Sends a player to a community event.
        // 
        // If the event is not currently happening, shows the page for it on the watch.
        void GoToEvent(Player player, object communityEvent);

        // Execution sends the specified player to a preconfigured destination. Use a destination constant or variable to specify the destination of this chip. Follow settings are a property of the destination.
        void GoToRoom(Player player, DestinationRoom destination);

        // Transitions to the given state in the current state machine.
        void GoToState(State state);

        // Returns whether the Grabber is currently holding an object, and a reference to that object if so. If no object is held, returns Invalid Object.
        (bool HasHeldObject, RecRoomObject HeldObject) GrabberGetHeldObjectR2(Grabber target);

        // On execution, the target Grabber will attempt to grab the specified object. If Steal From Player is true, it will steal the object from a player who has it held or holstered. If Snap to Grabber is true, the object will be moved to the Grabber’s position. If Snap to Grabber is false, the distance between Grabber and object at the moment of execution will be maintained until the object is released.
        bool GrabberGrabObjectR2(Grabber target, RecRoomObject @object, bool stealFromPlayer, bool snapToGrabber);

        // On execution, the target Grabber will release anything it’s holding. If an object is dropped, a reference to that object will be passed as an output. If nothing is dropped, it will return Invalid Object.
        RecRoomObject GrabberReleaseR2(Grabber target);

        // On execution, the target grabber will lock or unlock the object being held. If true, the held object will interactable for a player to steal.  If false, the held object will not be interactable for a player to steal.
        void GrabberSetPlayerCanStealFromGrabberR2(Grabber target, bool enabled);

        // Grants the contents of a Reward to the specified Player.
        bool GrantReward(Player player, Reward reward, AlternativeExec<bool> onAwardComplete);

        // Returns true if the current circuit graph is active. When inactive, circuit events will not run.
        bool GraphGetIsActive();

        // Returns True if input A is greater than or equal to input B.
        bool GreaterOrEqual(int a, int b);

        // Returns True if input A is greater than or equal to input B.
        bool GreaterOrEqual(float a, float b);

        // Returns True if input A is greater than or equal to input B.

        // Returns True if input A is greater than or equal to input B.

        // Returns True if input A is greater than input B.
        bool GreaterThan(int a, int b);

        // Returns True if input A is greater than input B.
        bool GreaterThan(float a, float b);

        // Returns True if input A is greater than input B.

        // Returns True if input A is greater than input B.

        // Ground vehicle add boost fuel
        void GroundVehicleAddBoostFuel(GroundVehicle target, int boostAmount);

        // Ground vehicle apply boost
        void GroundVehicleApplyBoost(GroundVehicle target, AlternativeExec failure);

        // Ground vehicle get boost fuel
        int GroundVehicleGetBoostFuel(GroundVehicle target);

        // Ground vehicle get driving enabled
        bool GroundVehicleGetDrivingEnabled(GroundVehicle target);

        // Ground vehicle get engine torque multiplier
        float GroundVehicleGetEngineTorqueMultiplier(GroundVehicle target);

        // Ground vehicle get seated player
        Player GroundVehicleGetSeatedPlayer(GroundVehicle target, int seatIndex);

        // Ground vehicle get wheel friction multiplier
        float GroundVehicleGetWheelFrictionMultiplier(GroundVehicle target);

        // Ground vehicle set driving enabled
        void GroundVehicleSetDrivingEnabled(GroundVehicle target, bool enabled);

        // Ground vehicle set engine torque multiplier
        void GroundVehicleSetEngineTorqueMultiplier(GroundVehicle target, float torqueMultiplier);

        // Ground vehicle set seated player
        void GroundVehicleSetSeatedPlayer(GroundVehicle target, int seatIndex, Player player, AlternativeExec failure);

        // Wheel Friction affects how good the wheels are at gripping the ground - lower values decrease traction and make the wheels slip more and higher values can increase traction and make the wheels slip less. 1 is the default value for Wheel Friction.
        void GroundVehicleSetWheelFrictionMultiplier(GroundVehicle target, float frictionMultiplier);

        // Ground vehicle unseat player
        void GroundVehicleUnseatPlayer(GroundVehicle target, Player player, AlternativeExec failure);

        // Ground vehicle unseat player from seat
        void GroundVehicleUnseatPlayerFromSeat(GroundVehicle target, int seatIndex, AlternativeExec failure);

        // Gun handle apply recoil
        void GunHandleApplyRecoil(GunHandle target, float angleX, float angleY, float duration, float returnDuration);

        // Returns whether the given gun handle will fire continuously.
        bool GunHandleGetContinuousFire(GunHandle target);

        // Gun handle get current ammo
        int GunHandleGetCurrentAmmo(GunHandle target);

        // Gun handle get firing direction
        Vector3 GunHandleGetFiringDirection(GunHandle target, RecRoomObject source);

        // Gun handle get is reloading
        bool GunHandleGetIsReloading(GunHandle target);

        // Gun handle get max ammo
        int GunHandleGetMaxAmmo(GunHandle target);

        // Gun handle get rate of fire
        float GunHandleGetRateOfFire(GunHandle target);

        // Gun handle get reload duration
        float GunHandleGetReloadDuration(GunHandle target);

        // Gun handle get supports reload
        bool GunHandleGetSupportsReload(GunHandle target);

        // Gun handle set a d s enabled
        void GunHandleSetADSEnabled(GunHandle target, bool enabled);

        // Sets whether the given gun handle will fire continuously.
        void GunHandleSetContinuousFire(GunHandle target, bool continuousFire);

        // Gun handle set current ammo
        void GunHandleSetCurrentAmmo(GunHandle target, int ammo);

        // Gun handle set max ammo
        void GunHandleSetMaxAmmo(GunHandle target, int maxAmmo);

        // Gun handle set rate of fire
        void GunHandleSetRateOfFire(GunHandle target, float rateOfFire);

        // Gun handle set reload duration
        void GunHandleSetReloadDuration(GunHandle target, float reloadDuration);

        // Gun handle set supports reload
        void GunHandleSetSupportsReload(GunHandle target, bool canReload);

        // Gets the primary action label on the target handle type object
        string HandleGetControlPrompt(Handle target);

        // Gets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle's configure menu for this to work.

        // Sets the primary action label on the target handle type object
        void HandleSetControlPrompt(Handle target, string controlPrompt);

        // Sets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle's configure menu for this to work.
        void HandleSetPlayerFilterTagsR2(Handle target, List<string> value);

        // Outputs True if the input object or player has the input tag.
        bool HasTag(Player target, string tag);

        // Outputs True if the input object or player has the input tag.
        bool HasTag(RecRoomObject target, string tag);

        // Get current playback time for Target Holotar Projector
        float HolotarProjectorGetCurrentTime(HolotarProjector target);

        // Holotar Projector get playback volume
        float HolotarProjectorGetVolume(HolotarProjector target);

        // Pasue Holotar Projector at current playback time
        void HolotarProjectorPause(HolotarProjector target);

        // Load & play Holotar Recording from the start through the Target Projector. Play will always begin the clip from 0s
        void HolotarProjectorPlay(HolotarProjector target, HolotarRecording holotar);

        // Resume playing the currently loaded clip on the Target Projector from the current time
        void HolotarProjectorResume(HolotarProjector target);

        // Set playback time for Target Projector when paused or playing
        void HolotarProjectorSetCurrentTime(HolotarProjector target, float time);

        // Holotar Projector set playback volume
        void HolotarProjectorSetVolume(HolotarProjector target, float volume);

        // Holotar Projector end play
        void HolotarProjectorStop(HolotarProjector target);

        // Constant to record and save a Holotar clip
        HolotarRecording HolotarRecordingConstant();

        // Holster object
        bool HolsterObject(Player player, RecRoomObject objectToHolster, bool forceHolster, bool steal);

        // Return a color from the given hue, saturation, and value inputs. All inputs are in the range [0, 1].
        Color HSVToColor(float hue, float saturation, float value);

        // Takes a boolean condition as an input. If True, the "Then" exec pin fires. If False, the "Else" exec pin fires.
        void If(bool condition, AlternativeExec @else);

        // Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        void IfHasTag(Player target, string tag, AlternativeExec doesNotHaveTag);

        // Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        void IfHasTag(RecRoomObject target, string tag, AlternativeExec doesNotHaveTag);

        // I'm Authority exec fires on the player's machine who has authority in the current context. At the room level, this is room authority, inside an object board, this is object authority. I'm Not Authority exec fires for everyone else.
        void IfLocalPlayerIsAuthority(AlternativeExec imNotAuthority);

        // I'm Authority exec fires on the player's machine who has authority over the room. I'm Not Authority exec fires for everyone else.
        void IfLocalPlayerIsRoomAuthority(AlternativeExec imNotAuthority);

        // The "Should Run" port will exec a) if the input player is local or b) if input player is invalid and the local player has authority of the current context.
        void IfLocalPlayerShouldRun(Player actingPlayer, AlternativeExec shouldNotRun);

        // Runs Has Role if the input player has the input role, otherwise runs Does Not Have Role.
        void IfPlayerHasRoleR1(Player player, string role, AlternativeExec doesNotHaveRole);

        // Outputs if a player is the local player or not.
        void IfPlayerIsLocal(Player player, AlternativeExec isNotLocal);

        // Runs Is Valid if the input player is not null, otherwise runs Is Not Valid. Players can be not valid if a variable is never set or if a player has left the room.
        void IfPlayerIsValid(Player player, AlternativeExec isNotValid);

        // If the input player is invalid, this runs Is Not Valid. If the input player is valid but not the local player, this runs Is Valid And Not Local. If the input player is both valid and the local player, this runs Is Valid And Local. Players can be invalid if a variable is never set or if a player has left the room.
        void IfPlayerIsValidAndLocal(Player player, AlternativeExec isNotValid, AlternativeExec isValidAndNotLocal);

        // Outputs one input value based on the input condition. Outputs the "Then" input if the input condition is True. Outputs the "Else" input if the input condition is False. Only reads one of the inputs, not both.
        void In();

        // Returns true when the current room instance is a player run event.
        bool InstanceGetIsEvent();

        // Returns true when the current room instance is part of a multi-instance event.
        bool InstanceGetIsMultiInstanceEvent();

        // Returns True if the current room instance is private.
        bool InstanceGetIsPrivate();

        // Returns the number of seconds since the current room instance was created.
        float InstanceGetLifetime();

        // Returns the maximum number of players that can fit in this room, as set in subroom settings.
        int InstanceGetMaxPlayers();

        // Gets the required hold time for the target Interaction Volume.
        float InteractionVolumeGetHoldTime(InteractionVolume target);

        // Gets the interaction prompt of an Interaction Volume.
        string InteractionVolumeGetInteractionPrompt(InteractionVolume target);

        // Returns False if the Interaction Volume is enabled, and True if it is locked.
        bool InteractionVolumeGetIsLocked(InteractionVolume target);

        // Gets the normalized hold progress for the target Interaction Volume.
        float InteractionVolumeGetNormalizedHoldProgress(InteractionVolume target);

        // Sets the required hold time for the target Interaction Volume.
        void InteractionVolumeSetHoldTime(InteractionVolume target, float holdTime);

        // Sets the interaction prompt of an Interaction Volume.
        void InteractionVolumeSetInteractionPrompt(InteractionVolume target, string interactionPrompt);

        // Disables or enables an Interaction Volume (but reversed).
        void InteractionVolumeSetLocked(InteractionVolume target, bool locked);

        // Sets the normalized hold progress for the target Interaction Volume.
        void InteractionVolumeSetNormalizedHoldProgress(InteractionVolume target, float normalizedHoldProgress);

        // Converts the input int to a float.
        float IntToFloat(int value);

        // Reads or writes a variable in the current scope based on the name.
        int IntVariable(int port1, VariableData config);

        // Add an inventory item to the given player.
        (bool Success, int TotalCount) InventoryItemAddR2(InventoryItem inventoryItem, Player player, int quantity, AlternativeExec<(bool Success, int TotalCount);

        // Inventory item constant r2
        InventoryItem InventoryItemConstantR2();

        // Get the count of how many of the given inventory item the given player owns.
        int InventoryItemGetCountR2(InventoryItem inventoryItem, Player player, AlternativeExec<int> complete);

        // Gets the friendly name, description, image, and tag names of the given inventory item.
        (string Name, string Description, bool SupportsUseAction, RecNetImage Image) InventoryItemGetDefinitionR2(InventoryItem inventoryItem);

        // Gets the image of the given inventory item
        RecNetImage InventoryItemGetImageR2(InventoryItem inventoryItem);

        // Remove an inventory item from the given player.
        (bool Success, int TotalCount) InventoryItemRemoveR2(InventoryItem inventoryItem, Player player, int quantity, AlternativeExec<(bool Success, int TotalCount);

        // Uses the given inventory item.
        void InventoryItemUseR2(InventoryItem inventoryItem);

        // Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        float InverseLerp(float start, float end, float value);

        // Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        float InverseLerp(Color start, Color end, Color value);

        // Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        float InverseLerp(Vector3 start, Vector3 end, Vector3 value);

        // Computes an inverse linear interpolation. The output is not clamped.
        float InverseLerpUnclamped(float start, float end, float value);

        // Computes an inverse linear interpolation. The output is not clamped.
        float InverseLerpUnclamped(Color start, Color end, Color value);

        // Computes an inverse linear interpolation. The output is not clamped.
        float InverseLerpUnclamped(Vector3 start, Vector3 end, Vector3 value);

        // Outputs True if the target Invisible Collision object is set to collide with players.
        bool InvisibleCollisionGetBlocksPlayers(InvisibleCollision target);

        // Outputs True if the target Invisible Collision object is enabled.
        bool InvisibleCollisionGetEnabled(InvisibleCollision target);

        // Sets the player collision state of a target Invisible Collision object.
        void InvisibleCollisionSetBlocksPlayers(InvisibleCollision target, bool enabled);

        // Sets the enabled state of a target Invisible Collision object.
        void InvisibleCollisionSetEnabled(InvisibleCollision target, bool enabled);

        // Returns True if the input variable is not null. Certain variable types must be set before use because they can't have a default value. A Rec Room Object variable that isn't set isn't going to be valid.
        Color LaserPointerGetColor(LaserPointer target);

        // Laser pointer get enabled
        bool LaserPointerGetEnabled(LaserPointer target);

        // Laser pointer get length
        float LaserPointerGetLength(LaserPointer target);

        // Laser pointer set color
        void LaserPointerSetColor(LaserPointer target, Color color);

        // Laser pointer set enabled
        void LaserPointerSetEnabled(LaserPointer target, bool enabled);

        // Laser pointer set length
        void LaserPointerSetLength(LaserPointer target, float length);

        // Get the leaderboard stat for the given player on the given stat channel.
        int LeaderboardGetPlayerStat(Player player, int channel, AlternativeExec<int> onGetStatComplete);

        // Outputs True if the target Leaderboard object is enabled.
        bool LeaderboardGetProjectorEnabled(LeaderboardProjector target);

        // Set the leaderboard stat for the local player on the given stat channel.
        void LeaderboardSetLocalPlayerStat(int channel, int value);

        // Sets the enabled state of the target Leaderboard object.
        void LeaderboardSetProjectorEnabled(LeaderboardProjector target, bool enabled);

        // Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        float Lerp(float start, float end, float progress);

        // Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        Quaternion Lerp(Quaternion start, Quaternion end, float progress);

        // Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        Vector3 Lerp(Vector3 start, Vector3 end, float progress);

        // Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        Color Lerp(Color start, Color end, float progress);

        // Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        float LerpUnclamped(float start, float end, float progress);

        // Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        Quaternion LerpUnclamped(Quaternion start, Quaternion end, float progress);

        // Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        Vector3 LerpUnclamped(Vector3 start, Vector3 end, float progress);

        // Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        Color LerpUnclamped(Color start, Color end, float progress);

        // Returns True if input A is less than or equal to input B.
        bool LessOrEqual(int a, int b);

        // Returns True if input A is less than or equal to input B.
        bool LessOrEqual(float a, float b);

        // Returns True if input A is less than or equal to input B.

        // Returns True if input A is less than or equal to input B.

        // Returns True if input A is less than input B.
        bool LessThan(int a, int b);

        // Returns True if input A is less than input B.
        bool LessThan(float a, float b);

        // Returns True if input A is less than input B.

        // Returns True if input A is less than input B.

        // Returns the angle in degrees of the target Dome Light or Spotlight.
        float LightGetAngle(Light target);

        // Returns the color of the target light.
        Color LightGetColor(Light target);

        // Returns True if the target light is emitting light.
        bool LightGetEnabled(Light target);

        // Returns the intensity of the target light.
        float LightGetIntensity(Light target);

        // Returns the range of the target light.
        float LightGetRange(Light target);

        // Returns the softness value of the target light.
        float LightGetSoftness(Light target);

        // Returns the specular contribution of the target light.
        float LightGetSpecularContribution(Light target);

        // Sets the angle of the spotlight's cone.
        void LightSetAngle(Light target, float angle);

        // Sets the angle of the spotlight's cone.

        // Sets the color for a point light or a spotlight.
        void LightSetColor(Light target, Color color);

        // Sets the color for a point light or a spotlight.

        // Sets whether or not a Light is enabled and will emit light.
        void LightSetEnabled(Light target, bool enabled);

        // Sets the brightness level for a point light or a spotlight.
        void LightSetIntensity(Light target, float intensity);

        // Sets the brightness level for a point light or a spotlight.

        // Sets the range of a point light or a spotlight.
        void LightSetRange(Light target, float range);

        // Sets the range of a point light or a spotlight.

        // Light set softness
        void LightSetSoftness(Light target, float softness);

        // Light set specular contribution
        void LightSetSpecularContribution(Light target, float specularContribution);

        // Turns off the point light or the spotlight.
        void LightTurnOff(Light target);

        // Turns on the point light or the spotlight.
        void LightTurnOn(Light target);

        // Adds a new element to the end of the target list containing the input value.

        // Adds a new element to the end of the target list containing the input value, but only if the element isn't already in the list.

        // If all of the bool values in the list are True then return true.
        bool ListAllTrue(List<bool> target);

        // If any bool value in the list is True then return True.
        bool ListAnyTrue(List<bool> target);

        // Reads or writes a variable in the current scope based on the name.

        // Removes all elements from a list

        // Reads or writes a variable in the current scope based on the name.

        // Combine lists together into one list.

        // Outputs True if the target list contains the input value.

        // Returns a shallow clone of the given list.

        // Creates a list from input values. Add more inputs by using the configure tool on the node and press "Add Input". All items in a list must be of the same type.

        // Stores a list of Destinations. Use constants to configure destinations.

        // Outputs a copy of the input list containing only its unique elements.

        // Divides each element in the list by the next element.
        float ListDivide(List<float> target);

        // Divides each element in the list by the next element.
        int ListDivide(List<int> target);

        // Divides each element in the list by the next element.
        Vector3 ListDivide(List<Vector3> target);

        // Get a list of all elements that appear in the first list but not in the other lists.

        // Reads or writes a variable in the current scope based on the name.

        // Returns list of all indices of input item in target list if that list contains one or more instances of the item. Otherwise returns an empty list.

        // Outputs the number of elements inside the input list.

        // Gets a specified element from the input list. The "Index" is the location of the element in the list. The first element in the list is at index 0, the second element is at index 1.

        // Returns first index of the item in target list if that list contains it. Otherwise returns -1.

        // Insert a new element into the target list at the input index. The new element contains the input value.

        // Get a list of the elements that appear in every input list.

        // Reads or writes a variable in the current scope based on the name.

        // Outputs the highest value in the target list.
        float ListMax(List<float> target);

        // Outputs the highest value in the target list.
        int ListMax(List<int> target);

        // Outputs the lowest value in the target list.
        float ListMin(List<float> target);

        // Outputs the lowest value in the target list.
        int ListMin(List<int> target);

        // Multiplies each element in the list by the next element.
        float ListMultiply(List<float> target);

        // Multiplies each element in the list by the next element.
        int ListMultiply(List<int> target);

        // Multiplies each element in the list by the next element.
        Quaternion ListMultiply(List<Quaternion> target);

        // Multiplies each element in the list by the next element.
        Vector3 ListMultiply(List<Vector3> target);

        // Reads or writes a variable in the current scope based on the name.

        // Reads or writes a variable in the current scope based on the name.

        // Reads or writes a variable in the current scope based on the name.

        // Remove an element in the target list at the input index.

        // Removes all instances of item from list.

        // Removes the first instance of the item in the list, and returns the index where it was found (-1 if not present)

        // Removes the last element in a list.

        // A list of Rewards

        // Sets a value at a location in a list.

        // Randomize the order of the values in the given list.

        // Sorts the given list in place in either ascending or descending order.
        void ListSort(List<float> target, bool ascending);

        // Sorts the given list in place in either ascending or descending order.
        void ListSort(List<int> target, bool ascending);

        // Sorts the given list in place in either ascending or descending order.
        void ListSort(List<string> target, bool ascending);

        // Reads or writes a variable in the current scope based on the name.

        // Subtracts each element in the list by the next element.
        float ListSubtract(List<float> target);

        // Subtracts each element in the list by the next element.
        int ListSubtract(List<int> target);

        // Subtracts each element in the list by the next element.
        Vector3 ListSubtract(List<Vector3> target);

        // Adds each element in the list by the next element.
        float ListSum(List<float> target);

        // Adds each element in the list by the next element.
        int ListSum(List<int> target);

        // Adds each element in the list by the next element.
        Vector3 ListSum(List<Vector3> target);

        // Combine lists together into one list and remove any duplicate elements.

        // Reads or writes a variable in the current scope based on the name.

        // Clears the local player's override of target player's voice rolloff distance.
        // 
        // The local player's reckoning of the target player's voice rolloff returns to being based on that player's voice rolloff distance property.
        void LocalPlayerClearPlayerVoiceRolloffOverrideR2(Player player);

        // Removes the ability for the local player to interact with the provided player. This state is NOT synced with other users, and player interactivity will be removed only for players that ran this chip.
        void LocalPlayerDisableInteractionWithTargetPlayer(Player player);

        // Enables the local player to interact with the provided player. To respond to interactions, configure a "Event Receiver" chip for the "Local Player... Interaction" events within a Player board. Hold duration is the number of seconds the player needs to hold the interact button to complete an interaction. If Hold duration is 0, the interaction will be a button press or tap on mobile platforms. Prompt is the string that will be displayed when a player interacts with the provided player.  Players will be interactive only for the players that ran this chip with them as the target player. Individual players may have different sets of players they can interact with. A player's interaction state is reset when the room is reset or reloaded. Enabling interactions with a player will make it so gestures do not work with them generally (e.g.: fistbumping, high-fiving, handshaking).
        void LocalPlayerEnableInteractionWithTargetPlayer(Player player, float requiredHoldDuration, string prompt);

        // Outputs the direction of Local Player Gaze.
        Vector3 LocalPlayerGazeDirection();

        // Outputs the origin of Local Player Gaze.
        Vector3 LocalPlayerGazeOrigin();

        // Checks if the local player is in third-person mode. This always returns false for platforms that do not support third person like VR.
        bool LocalPlayerGetIsThirdPersonActive();

        // Get the current displayed content on the Objective Log HUD UI
        (string HeaderText, Color HeaderTextColor, string BodyText, Color BodyTextColor) LocalPlayerGetObjectiveLogContent();

        // Get if the Objective Log HUD UI is currently enabled
        bool LocalPlayerGetObjectiveLogEnabled();

        // Check whether the local player is using a controller or not.
        bool LocalPlayerIsUsingController();

        // Check whether the local player is using keyboard and mouse controls or not.
        bool LocalPlayerIsUsingKeyboardAndMouse();

        // Check whether the local player is using touch controls or not.
        bool LocalPlayerIsUsingTouch();

        // Check whether the local player is in VR or not.
        bool LocalPlayerIsVR();

        // Override the voice rolloff distance of the target player as heard by the local player.
        // 
        // Other players' perception of the target player's voice rolloff will be unaffected.
        void LocalPlayerOverridePlayerVoiceRolloffR2(Player player, float voiceRolloffDistance);

        // Tries to set the local player to third or first person. If Active is true, the local player will be changed to third person. If Active is false, they will be changed to first person. No effect on platforms where third person is unsupported, like VR.
        void LocalPlayerRequestThirdPerson(bool active);

        // Sets whether gravity should be disabled for the local player
        void LocalPlayerSetGravityDisabledR2(bool disabled);

        // Sets whether specific locomotion visual feedback effects should play when in the corresponding state.
        void LocalPlayerSetLocomotionVFXEnabledR2(bool sprintWind, bool wallRunWind, bool slideStartWind, bool slideWind, bool slideSparks);

        // Set the content to be displayed on the Objective Log HUD UI
        void LocalPlayerSetObjectiveLogContent(string headerText, Color headerTextColor, string bodyText, Color bodyTextColor);

        // Set whether the Objective Log HUD UI is enabled
        void LocalPlayerSetObjectiveLogEnabled(bool enable);

        // Control whether the player sees the nametag of the target player.It takes priority over role settings.Reset the room to remove the effect of this chip.
        void LocalPlayerSetPlayerNametagVisibility(Player player, bool enabled);

        // Request that the local player perform a clamber or a mantle. Custom Locomotion must be enabled in the active Player Definition Board.
        void LocomotionRequestClamberR2(Vector3 ledgePosition, Vector3 wallNormal, RecRoomObject wallObject, bool mantle, float duration, float postClamberVelocityMultiplier);

        // Request that the local player crouch.
        void LocomotionRequestCrouchR2();

        // Locomotion request fly start r2
        void LocomotionRequestFlyStartR2();

        // Locomotion request fly stop r2
        void LocomotionRequestFlyStopR2();

        // Request that the local player's jump is cancelled or shortened.
        void LocomotionRequestJumpCutoffR2();

        // Request that the local player jumps.
        void LocomotionRequestJumpR2(float maxJumpHeight, Vector3 direction);

        // Request that the local player becomes prone.
        void LocomotionRequestProneR2();

        // Used for custom locomotion in order to request starting a slide.
        void LocomotionRequestSlideR2(float slideSpeed, float minSlideSpeed, bool slideWithGravity);

        // Used for custom locomotion in order to request starting a sprint.
        void LocomotionRequestSprintStartR2();

        // Request that the local player's sprint stops.
        void LocomotionRequestSprintStopR2();

        // Requests that the local player stand.
        void LocomotionRequestStandR2();

        // Request that the local player is steered in the given direction, at the given speed.
        void LocomotionRequestSteeringR2(Vector3 direction, float normalizedSpeed, float maxSteeringSpeed, float accelerationTime);

        // Requests for the local player to start wall climbing. Will only start a wall climb if executed by the Locomotion Wall Climb Ready event.
        void LocomotionRequestWallClimbStartR2();

        // Requests for the player to stop wall climbing, if they are currently wall climbing.
        void LocomotionRequestWallClimbStopR2();

        // Request that the local player begin to wall run. Only works if called via an exec line from the WallRunReady event.
        // Not affected by CanWallRun. If you want that property to impact this request you should check it yourself.
        void LocomotionRequestWallRunR2(float gravityMultiplier);

        // Request that the local player stop wall running. Not affected by CanWallRun directly. If you want that property to impact this request you should check it yourself.
        void LocomotionRequestWallRunStopR2();

        // Locomotion set steering input enabled
        void LocomotionSetSteeringInputEnabled(bool enabled);

        // Computes a logarithm.
        float Logarithm(float value, float @base);

        // Logs the given error message to the logging tab of your palette.
        void LogError(string error);

        // Logs a string to the logging tab of your palette.
        void LogString(string text);

        // Returns largest of two or more values.
        int Max(params int[] value);

        // Returns largest of two or more values.
        float Max(params float[] value);

        // Returns smallest of two or more values.
        int Min(params int[] value);

        // Returns smallest of two or more values.
        float Min(params float[] value);

        // Outputs the modulo of the first value when divided by the second.
        int Modulo(params int[] value);

        // Outputs the modulo of the first value when divided by the second.
        float Modulo(params float[] value);

        // Multiplies the two or more input values and outputs the result.
        int Multiply(params int[] value);

        // Multiplies the two or more input values and outputs the result.
        float Multiply(params float[] value);

        // Multiplies the two or more input values and outputs the result.
        Quaternion Multiply(params Quaternion[] value);

        // Multiplies the two or more input values and outputs the result.
        Vector3 Multiply(params Vector3[] value);

        // Choose from a selection of music tracks, for use with the Audio Player.
        Audio MusicConstant();

        // Outputs False only when all inputs are True. If any input is False, it outputs True.
        bool Nand(bool input);

        // Checks if a path exists between two positions using the NavMesh.
        // 
        // Use "Max Distance" to indicate how far away from the NavMesh the positions can be. Lower values increase precision and can cause valid paths to register false if the target positions are not close enough to the NavMesh, while higher values decrease precision and can return a false positive if the margin is wide enough to include points that are not near the NavMesh.
        bool NavMeshCanPathBetween(Vector3 startPosition, Vector3 endPosition, float maxDistance);

        // Nav mesh sample position
        (bool IsValid, Vector3 HitPosition) NavMeshSamplePosition(Vector3 sourcePosition, float maxDistance);

        // Samples a 3D Perlin noise field and returns a value usually bounded in [0,1].
        float Noise(Vector3 point);

        // Outputs True when all inputs are False. Otherwise, outputs False.
        bool Nor(bool input);

        // Outputs the opposite of the input boolean.
        bool Not(bool value);

        // Compares the input values and outputs True if they are different. False if they are the same.

        // Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarker target, Player playerOrObject);

        // Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarker target, RecRoomObject playerOrObject);

        // Objective Marker Constant defines the default appearance of an Objective Marker. Use with Objective Marker Set Enabled, Objective Marker Set Position, and the other Objective Marker chips.
        ObjectiveMarker ObjectiveMarkerConstant();

        // Objective Marker Get Color returns the current color of target Objective Marker for the local player.
        Color ObjectiveMarkerGetColor(ObjectiveMarker target);

        // Objective Marker Get Current Distance returns the current distance of the local player from the target Objective Marker, regardless of whether the distance indicator is enabled.
        float ObjectiveMarkerGetCurrentDistance(ObjectiveMarker target);

        // Objective Marker Get Distance Is Enabled returns whether or not the target Objective Marker’s distance indicator is visible for the local player.
        bool ObjectiveMarkerGetDistanceEnabled(ObjectiveMarker target);

        // Objective Marker Get Enabled returns whether or not the target Objective Marker is enabled for the local player.
        bool ObjectiveMarkerGetEnabled(ObjectiveMarker target);

        // Objective Marker Get Fade Threshold returns the current fade threshold of the target Objective Marker for the local player.
        float ObjectiveMarkerGetFadeThreshold(ObjectiveMarker target);

        // Objective Marker Get Label returns the current text label of target Objective Marker for the local player as a string.
        string ObjectiveMarkerGetLabel(ObjectiveMarker target);

        // Objective Marker Get Label Is Enabled returns whether or not the target Objective Marker’s text label is visible for the local player.
        bool ObjectiveMarkerGetLabelEnabled(ObjectiveMarker target);

        // Objective Marker Get Position returns target Objective Marker’s current position for the local player as a vector
        Vector3 ObjectiveMarkerGetPosition(ObjectiveMarker target);

        // Objective Marker Get Target Object returns the object targeted by target Objective Marker, if it’s tracking an object. If target Objective Marker is not tracking an object, returns Invalid Object.
        RecRoomObject ObjectiveMarkerGetTargetObject(ObjectiveMarker target);

        // Objective Marker Get Target Player returns the player targeted by target Objective Marker, if it’s tracking a player. If target Objective Marker is not tracking a player, returns Invalid Player.
        Player ObjectiveMarkerGetTargetPlayer(ObjectiveMarker target);

        // Objective Marker Set Color sets target Objective Marker to the specified color for the local player.
        void ObjectiveMarkerSetColor(ObjectiveMarker target, Color color);

        // Objective Marker Set Distance Enabled enables or disables the visibility of the target Objective Marker’s distance indicator for the local player.
        void ObjectiveMarkerSetDistanceEnabled(ObjectiveMarker target, bool enabled);

        // Objective Marker Set Enabled enables or disables the target Objective Marker for the local player. Use with Objective Marker constant.
        void ObjectiveMarkerSetEnabled(ObjectiveMarker target, bool enabled);

        // Objective Marker Set Fade Threshold sets the fade threshold of the target Objective Marker for the local player. This threshold is the distance (in meters) at which the marker has fully faded from sight as a player approaches it. For finer control over the fade duration, configure the Objective Marker constant.
        void ObjectiveMarkerSetFadeThreshold(ObjectiveMarker target, float proximity);

        // Objective Marker Set Label sets the text label of target Objective Marker to the specified string for the local player.
        void ObjectiveMarkerSetLabel(ObjectiveMarker target, string label);

        // Objective Marker Set Label Enabled enables or disables the visibility of the target Objective Marker’s text label for the local player.
        void ObjectiveMarkerSetLabelEnabled(ObjectiveMarker target, bool enabled);

        // Objective Marker Set Position sets the position of target Objective Marker to a position vector for the local player.
        void ObjectiveMarkerSetPosition(ObjectiveMarker target, Vector3 position);

        // Outputs True if any input is True. Otherwise outputs False.
        bool Or(params bool[] input);

        // Out
        void Out();

        // Get information about all the objects/players within a box defined by its center, extents, and orientation. (position, distance, direction, etc.)

        // Get information about all the objects/players within a certain distance of a point in space (position, distance, direction, etc.)

        // Converts the input string to a bool if able.
        (bool Result, bool ParseSuccess) ParseBool(string @string);

        // Attempt to parse the given string as a hexadecimal color in the '#RRGGBB' format.
        (Color Result, bool ParseSuccess) ParseColor(string @string);

        // Converts the input string to a float if able.
        (float Result, bool ParseSuccess) ParseFloat(string @string);

        // Converts the input string to a integer if able.
        (int Result, bool ParseSuccess) ParseInt(string @string);

        // Parses the input date and time and returns the corresponding universal seconds. The chip will automatically try to find the correct format of the input data.
        (int UniversalSeconds, bool Success) ParseTime(string time);

        // Pathfinder get enable ground clamping r2
        bool PathfinderGetEnableGroundClampingR2(Pathfinder pathfinder);

        // Gets the maximum acceleration of the Pathfinder, in meters per second squared
        float PathfinderGetMaxAccelerationR2(Pathfinder pathfinder);

        // Pathfinder get max angular speed r2
        float PathfinderGetMaxAngularSpeedR2(Pathfinder pathfinder);

        // Pathfinder get max linear speed r2
        float PathfinderGetMaxLinearSpeedR2(Pathfinder pathfinder);

        // Gets the Pathfinder's current pathing state information
        // * Is Pathing
        // * Has Arrived
        // * Within Slowdown Distance
        (bool IsPathing, bool HasArrived, bool WithinSlowdownDistance) PathfinderGetPathingStateR2(Pathfinder pathfinder);

        // Gets the current pathing target (target position, slowdown and arrival distances) of the Pathfinder
        (Vector3 TargetPosition, float SlowdownDistance, float ArrivalDistance) PathfinderGetPathingTargetR2(Pathfinder pathfinder);

        // Gets the Pathfinder's current rotation state information
        // * Is Rotating
        // * Has Arrived
        (bool IsRotating, bool HasArrived) PathfinderGetRotationStateR2(Pathfinder pathfinder);

        // Gets the current pathing target (target direction, slowdown and arrival angles in degress) of the Pathfinder
        (Vector3 TargetDirection, float SlowdownAngle, float ArrivalAngle) PathfinderGetRotationTargetR2(Pathfinder pathfinder);

        // Toggles enabling ground clamping for the pathfinder
        void PathfinderSetGroundClampingR2(Pathfinder pathfinder, bool enable);

        // Sets the maximum linear acceleration of the Pathfinder, in meters per second squared
        void PathfinderSetMaxAccelerationR2(Pathfinder pathfinder, float maxAcceleration);

        // Sets the maximum angular speed of the Pathfinder, in degrees per second
        void PathfinderSetMaxAngularSpeedR2(Pathfinder pathfinder, float maxAngularSpeed);

        // Sets the maximum linear speed of the Pathfinder, in meters per second
        void PathfinderSetMaxLinearSpeedR2(Pathfinder pathfinder, float maxLinearSpeed);

        // Sets the object tags that the pathfinder ignores on collision
        void PathfinderSetTagsToIgnoreR2(Pathfinder pathfinder, List<string> tagsToIgnore);

        // Starts moving the Pathfinder towards the target position
        // It will slow down once it is within Slowdown Distance of the target
        // And stop once it is within Arrival Distance of the target
        void PathfinderStartPathingToPositionR2(Pathfinder pathfinder, Vector3 targetPosition, float slowdownDistance, float arrivalDistance);

        // Starts rotating the Pathfinder towards the target direction
        // Rotation target takes priority over automatically rotating to face the pathing direction
        // It will slow down once it is within Slowdown Angle (in degrees) of the target
        // And stop once it is within Arrival Angle (in degrees) of the target
        void PathfinderStartRotatingToDirectionR2(Pathfinder pathfinder, Vector3 targetDirection, float slowdownAngle, float arrivalAngle);

        // Stops moving the Pathfinder
        void PathfinderStopPathingR2(Pathfinder pathfinder);

        // Clears the target rotation of a Pathfinder
        // Automatic rotation to face the pathing direction will resume
        void PathfinderStopRotatingR2(Pathfinder pathfinder);

        // Gets the acceleration of a piston.
        float PistonGetAcceleration(Piston target);

        // Outputs the current distance of the target Piston.
        float PistonGetDistance(Piston target);

        // Outputs the max distance of the target Piston.
        float PistonGetMaxDistance(Piston target);

        // Returns the speed of a piston.
        float PistonGetSpeed(Piston target);

        // Outputs the set distance of the Marker on a target Piston.
        float PistonGetTargetDistance(Piston target);

        // Sets the acceleration of the target Piston.
        void PistonSetAcceleration(Piston target, float value);

        // Moves the target piston to the input distance.
        void PistonSetDistance(Piston target, float value);

        // Sets the max distance of a target Piston.
        void PistonSetMaxDistance(Piston target, float value);

        // Sets the speed of a target Piston.
        void PistonSetSpeed(Piston target, float value);

        // Sets the Marker distance of a target Piston.
        void PistonSetTargetDistance(Piston target, float value);

        // Play audio at position
        void PlayAudioAtPosition(Audio audio, Vector3 position, float volume, float playbackSpeed, bool is2D, PlayAudioAtPositionData config);

        // Adds a tag to the list of player tags that the provided player can target with aim assist.
        // By default, this list contains the #player tag.
        void PlayerAddAimAssistTag(Player player, string tag);

        // Adds a Role to a Player.
        void PlayerAddRoleR1(Player target, string value);

        // Award XP to specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        bool PlayerAwardXP(Player player, int amount, AlternativeExec<bool> onAwardComplete);

        // Outputs the rotation of a Player's body.
        Quaternion PlayerBodyOrientation(Player target);

        // Outputs the postion of a Player's body in world space.
        Vector3 PlayerBodyPosition(Player target);

        // Clears any subtitle which is currently being displayed for the given player.
        void PlayerClearCurrentSubtitle(Player player);

        // This is very similar to an object board that you would find on any object, except this is for all players! After placing, make sure to configure it and make sure it is active. Edit into this board and add any other chips you'd like and know that each player will have the same logic on them when you hit done editing.
        void PlayerDefinitionBoardEmpty();

        // For the target player, equip the specified Inventory Item to the specified Inventory Equipment Slot. If the Slot is of Inventory type, this chip will take effect whether or not the Slot is enabled, but the Slot must then be enabled separately.
        bool PlayerEquipInventoryItemR2(Player player, InventoryItem inventoryItem, EquipmentSlot inventoryEquipmentSlot, AlternativeExec<bool> onEquipComplete);

        // Gets the list of player tags that the provided player can target with aim assist.
        // By default, this list contains the #player tag.

        // Gets the fraction from 0 to 1 of the standard air control that this player has.
        // This is multiplied by the air control value for the user's current state to calculate their acceleration.
        // Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
        float PlayerGetAirControlPercentageR2(Player player);

        // Searches the room for all players with the input tag and outputs them as a list.
        bool PlayerGetCanFlyR2(Player player);

        // Returns whether a given player is allowed to teleport.
        // 
        // Note: The value of this property is independent of a player's platform. (This value can be true for screens players.)
        bool PlayerGetCanTeleportR2(Player player);

        // Gets whether the player can Wall Climb. Enforced via circuits.
        bool PlayerGetCanWallClimbR2(Player player);

        // Returns the costume that the given player is currently wearing.
        Costume PlayerGetCostume(Player player);

        // Returns whether crouch input is enabled for a given player
        bool PlayerGetCrouchInputEnabledR2(Player player);

        // Returns the crouch speed for a given player.
        float PlayerGetCrouchSpeedR2(Player player);

        // Returns true if the given player has their right hand set as dominant.
        bool PlayerGetDominantHandIsRight(Player player);

        // For the target player, get whether the specified equipment slot is enabled.
        bool PlayerGetEquipmentSlotIsEnabledR2(Player player, EquipmentSlot equipmentSlot);

        // Gets equipped objects from a player.
        (RecRoomObject DominantHandObject, RecRoomObject OffHandObject, RecRoomObject LeftHipHolsterObject, RecRoomObject RightHipHolsterObject, RecRoomObject ShoulderHolsterObject) PlayerGetEquippedObjects(Player player);

        // Gets the first player with the input tag.
        Player PlayerGetFirstWithTag(string tag);

        // Returns whether manual sprint is required for a given player
        bool PlayerGetForceManualSprintR2(Player player);

        // Returns whether Virtual Height Mode is required for a given player
        bool PlayerGetForceVirtualHeightModeR2(Player player);

        // Returns whether the given player will be forced to use walk mode if they are playing in VR.
        bool PlayerGetForceVRWalkR2(Player player);

        // Outputs if a Player is authority of the input object.
        bool PlayerGetIsAuthorityOf(Player target, RecRoomObject @object);

        // Whether or not the player is currently clambering or mantling up a ledge
        bool PlayerGetIsClambering(Player player);

        // Returns whether the given player is crouching
        bool PlayerGetIsCrouching(Player player);

        // Player get is custom footstep audio active
        bool PlayerGetIsCustomFootstepAudioActive(Player player);

        // Returns whether the given player is flying.
        bool PlayerGetIsFlying(Player player);

        // Returns whether the given player is grounded, a.k.a. not jumping, flying, wall-running, clambering, or falling. Also returns the time (in seconds) since they were last grounded, or 0 if currently grounded. Surface Object returns the Room Object that the player is standing on if they are grounded, or Invalid Object if the player is not grounded or standing on a non-Rec Room Object. Surface Normal returns the normal of the surface if the player is grounded and (0, 1, 0) if they're not.
        (bool IsGrounded, float TimeSinceLastGrounded, RecRoomObject SurfaceObject, Vector3 SurfaceNormal) PlayerGetIsGrounded(Player player);

        // Player get is jumping or falling
        (bool IsJumpingOrFalling, RecRoomObject ContactSurface) PlayerGetIsJumpingOrFalling(Player player);

        // Outputs True if the input player is the local player executing the chip on their machine.
        bool PlayerGetIsLocal(Player target);

        // Returns whether the given player is prone.
        bool PlayerGetIsProne(Player player);

        // Outputs True if the input Player is one of the current room's contributors.
        bool PlayerGetIsRoomContributor(Player target);

        // Outputs True if the input Player is one of the current room's hosts.
        bool PlayerGetIsRoomHost(Player target);

        // Outputs True if the input Player is one of the current room's moderators.
        bool PlayerGetIsRoomMod(Player target);

        // Outputs True if the input Player is one of the current room's owners.
        bool PlayerGetIsRoomOwner(Player target);

        // Returns whether the given player is sliding.
        bool PlayerGetIsSliding(Player player);

        // Returns whether the given player is sprinting.
        bool PlayerGetIsSprinting(Player player);

        // Gets whether the player is currently in the Wall Climb state.
        bool PlayerGetIsWallClimbing(Player player);

        // Returns whether the given player is wall running.
        bool PlayerGetIsWallRunning(Player player);

        // Returns the jump height for a given player
        float PlayerGetJumpHeightR2(Player player);

        // Returns whether jump input is enabled for a given player
        bool PlayerGetJumpInputEnabledR2(Player player);

        // (DEPRECATED: Use PlayerGetSteeringSpeed / GetWalkSpeed) Returns the steering speed requested by the player, squared, and normalized by the square of the default walk speed.

        // Gets the physics velocity for the given player.
        // Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources
        // Physics velocity will generally be reduced over time by drag from various sources.
        Vector3 PlayerGetPhysicsVelocityR2(Player player);

        // Returns a list of players that are set to the given radio channel.

        // Gets the profile image of the given player.
        RecNetImage PlayerGetProfileImage(Player player);

        // Returns the prone speed for a given player.
        float PlayerGetProneSpeedR2(Player player);

        // Get the radio channel number of a player. If a player is not in any, this node returns -1
        int PlayerGetRadioChannel(Player player);

        // Returns the unique index of this player in the room, bounded by the room capacity.
        int PlayerGetRoomIndex(Player player);

        // Returns the current Room Level of the specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        int PlayerGetRoomLevel(Player player);

        // Player get seat
        Seat PlayerGetSeat(Player player);

        // Returns the slide speed for a given player.
        float PlayerGetSlideSpeedR2(Player player);

        // Returns whether sprint input is enabled for a given player
        bool PlayerGetSprintInputEnabledR2(Player player);

        // Returns the sprint speed for a given player
        float PlayerGetSprintSpeedR2(Player player);

        // Player Get Steering Direction
        Vector3 PlayerGetSteeringDirection(Player player);

        // Player get steering input enabled
        bool PlayerGetSteeringInputEnabled(Player player);

        // Returns the steering speed requested by the player. This value represents how fast a player is wanting to move in world units.
        float PlayerGetSteeringSpeed(Player player);

        // Returns the teleport delay for a given player
        float PlayerGetTeleportDelayR2(Player player);

        // Returns the max teleport distance for a given player
        float PlayerGetTeleportDistanceR2(Player player);

        // Returns the offset of the given player's local time zone from UTC in seconds.
        int PlayerGetTimeZone(Player player);

        // Returns the voice rolloff distance for the target player, as reckoned by the local player.
        // 
        // If the local player has set an override for the target player's voice rolloff distance, the "Has Local Override" bool returns true, and the overridden value is returned.
        // 
        // Otherwise, the synced value of that player's voice rolloff distance is returned, and the bool returns false.
        (float VoiceRolloffDistance, bool HasLocalOverride) PlayerGetVoiceRolloffDistanceR2(Player player);

        // Gets the current microphone volume from the given player.
        float PlayerGetVolume(Player player);

        // Returns the walk speed for a given player
        float PlayerGetWalkSpeedR2(Player player);

        // Gets the whether the player can Wall Run. Enforced via circuits.
        bool PlayerGetWallRunEnabledR2(Player player);

        // Returns current XP of specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        int PlayerGetXP(Player player);

        // Player has purchased room offer r2
        bool PlayerHasPurchasedRoomOfferR2(Player player, RoomOffer roomOffer, AlternativeExec<bool> onPlayerHasPurchasedRoomOfferComplete);

        // Outputs True if the input player has the input role.
        bool PlayerHasRoleR1(Player target, string value);

        // Outputs the forward vector of a Player's head.
        Vector3 PlayerHeadForwardVector(Player target);

        // Outputs the height of a Player's head.
        float PlayerHeadHeight(Player target);

        // Outputs the rotation of a Player's head.
        Quaternion PlayerHeadOrientation(Player target);

        // Outputs the position of a Player's head in world space.
        Vector3 PlayerHeadPosition(Player target);

        // Outputs the up vector of a Player's head.
        Vector3 PlayerHeadUpVector(Player target);

        // Outputs the velocity of a Player's head.
        Vector3 PlayerHeadVelocity(Player target);

        // Outputs if the Player is holding their Maker Pen.
        // Useful for having different logic while creating.
        bool PlayerIsHoldingMakerPen(Player target);

        // Player is in party
        bool PlayerIsInParty(Player target);

        // Outputs the direction of a Player's left hand finger.
        Vector3 PlayerLeftHandFingerDirection(Player target);

        // Outputs the postion of a Player's left hand in world space.
        Vector3 PlayerLeftHandPosition(Player target);

        // Outputs the rotation of a Player's left hand.
        Quaternion PlayerLeftHandRotation(Player target);

        // Outputs the direction of a Player's left hand thumb.
        Vector3 PlayerLeftHandThumbDirection(Player target);

        // Outputs the velocity of a Player's left hand.
        Vector3 PlayerLeftHandVelocity(Player target);

        // Returns true if the given player owns at least one of the given inventory item.
        bool PlayerOwnsInventoryItemR2(Player player, InventoryItem inventoryItem, AlternativeExec<bool> complete);

        // Player owns room key r1
        bool PlayerOwnsRoomKeyR1(Player player, RoomKey roomKey, AlternativeExec<bool> onPlayerOwnsRoomKeyComplete);

        // Sends a prompt to the specified player containing the prompt title and body, along with each of the answer choices on its own line. The player can choose a response and hit "ok," triggering the On Prompt Complete event. Since there is a delay between sending a prompt and receiving the response in which other responses may be received, the Player output can be used to disambiguate multiple responses. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
        (bool Success, Player ReceivingPlayer, string Response, int ResponseIndex) PlayerPromptMultipleChoice(Player player, string promptTitle, string promptBody, List<string> answerChoices, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response, int ResponseIndex);

        // Sends a prompt to the specified player where they can input text, which is then returned by this chip's output. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
        (bool Success, Player ReceivingPlayer, string Response) PlayerPromptText(Player player, string promptTitle, string promptBody, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response);

        // Removes a tag from the list of player tags that the provided player can target with aim assist.
        // By default, this list contains the #player tag.
        void PlayerRemoveAimAssistTag(Player player, string tag);

        // Removes the input role from a target player.
        void PlayerRemoveRoleR1(Player target, string value);

        // Resets the color of the given player's name tag to the default color.
        void PlayerResetNameColor(Player player);

        // Outputs the direction of a Player's right hand finger.
        Vector3 PlayerRightHandFingerDirection(Player target);

        // Outputs the postion of a Player's right hand in world space.
        Vector3 PlayerRightHandPosition(Player target);

        // Outputs the rotation of a Player's right hand.
        Quaternion PlayerRightHandRotation(Player target);

        // Outputs the direction of a Player's right hand thumb.
        Vector3 PlayerRightHandThumbDirection(Player target);

        // Outputs the velocity of a Player's right hand.
        Vector3 PlayerRightHandVelocity(Player target);

        // Sets the list of player tags that the provided player can target with aim assist.
        // By default, this list contains the #player tag.
        void PlayerSetAimAssistTags(Player player, List<string> tags);

        // Sets the fraction from 0 to 1 of the standard air control that this player will have.
        // This is multiplied by the air control value for the user's current state to calculate their acceleration.
        // Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
        void PlayerSetAirControlPercentageR2(Player player, float airControlPercentage);

        // Player set can fly r2
        void PlayerSetCanFlyR2(Player player, bool canFly);

        // Sets whether a given player is allowed to teleport.
        // 
        // Note: Setting this to false does not prevent VR players from being in Teleport mode. It only prevents them from performing a teleport.
        void PlayerSetCanTeleportR2(Player player, bool canTeleport);

        // Sets whether the player can Wall Climb. Enforced via circuits.
        void PlayerSetCanWallClimbR2(Player player, bool wallClimbEnabled);

        // Sets whether crouch input is enabled for a given player. Setting this to false will remove crouch button prompts / UI elements on supported platforms.
        void PlayerSetCrouchInputEnabledR2(Player player, bool crouchInputEnabled);

        // Sets the crouch speed for a given player
        void PlayerSetCrouchSpeedR2(Player player, float crouchSpeed);

        // Enables the specified equipment slot on the target player
        void PlayerSetEquipmentSlotIsEnabledR2(Player player, EquipmentSlot equipmentSlot, bool isEnabled);

        // Sets whether manual sprint is required for a given player.
        // 
        // Players can choose whether they want to use auto sprint in their settings.
        void PlayerSetForceManualSprintR2(Player player, bool forceManualSprint);

        // Sets whether Virtual Height Mode is required for a given player.
        // 
        // Players can choose whether they want to use Physical Height Mode in their settings.
        void PlayerSetForceVirtualHeightModeR2(Player player, bool forceVirtualHeightMode);

        // Forces the given player to use walk rather than teleport mode if they are playing in VR. This is useful when you need access to their walk inputs which won't fire if they are in teleport mode. You should consider adding a warning to your room so teleport players are aware that you're going to change their movement mode.
        void PlayerSetForceVRWalkR2(Player player, bool forceVRWalk);

        // Sets the jump height for a given player
        void PlayerSetJumpHeightR2(Player player, float jumpHeight);

        // Sets whether jump input is enabled for a given player. Setting this to false will remove jump button prompts / UI elements on supported platforms.
        void PlayerSetJumpInputEnabledR2(Player player, bool jumpInputEnabled);

        // Player set name color
        void PlayerSetNameColor(Player player, Color color);

        // Sets the physics velocity for the given player.
        // Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources.
        // Physics velocity will generally be reduced over time by drag from various sources.
        // This node is similar Velocity Set. However, that node also zeroes the Steering Velocity.
        void PlayerSetPhysicsVelocityR2(Player player, Vector3 physicsVelocity);

        // Sets the prone speed for a given player
        void PlayerSetProneSpeedR2(Player player, float proneSpeed);

        // Assign a player to a radio channel. The channel needs to be a non-negative integer value. Players within the same channel will be able to communicate in team radio.
        void PlayerSetRadioChannel(Player player, int channel);

        // Sets the slide speed for a given player
        void PlayerSetSlideSpeedR2(Player player, float slideSpeed);

        // Sets whether sprint input is enabled for a given player. Setting this to false will remove sprint button prompts / UI elements on supported platforms.
        void PlayerSetSprintInputEnabledR2(Player player, bool sprintInputEnabled);

        // Sets the sprint speed for a given player
        void PlayerSetSprintSpeedR2(Player player, float sprintSpeed);

        // Sets whether walk input is enabled for a given player. Setting this to false will stop Steering Input events from firing, and will remove walk-related button prompts / UI elements on supported platforms.
        void PlayerSetSteeringInputEnabledR2(Player player, bool steeringInputEnabled);

        // Sets the steering velocity for the given player.
        // Steering Velocity should generally be modified via Locomotion Steering Request.
        // Setting it directly may result in animation artifacts but can be done in special cases.
        void PlayerSetSteeringVelocityR2(Player player, Vector3 steeringVelocity);

        // Sets the teleport delay for a given player
        void PlayerSetTeleportDelayR2(Player player, float teleportDelay);

        // Sets the max teleport distance for a given player
        void PlayerSetTeleportDistanceR2(Player player, float teleportDistance);

        // Sets the voice rolloff distance for a given player as heard by all other players.
        // 
        // Beyond this distance, the target player cannot be heard.
        void PlayerSetVoiceRolloffDistanceR2(Player player, float voiceRolloffDistance);

        // Sets the walk speed for a given player
        void PlayerSetWalkSpeedR2(Player player, float walkSpeed);

        // Sets the whether the player can Wall Run. Enforced via circuits.
        void PlayerSetWallRunEnabledR2(Player player, bool wallRunEnabled);

        // Displays a subtitle for a specified duration. If there is already a subtitle showing, it will be replaced only if this subtitle has an equal or higher priority. If the string is more than 200 characters, it will be displayed in multiple subtitles, each lasting a fraction of the total duration. Escape characters are ignored.
        void PlayerShowSubtitle(Player player, string subtitle, float duration, int priority);

        // Outputs True if the input Player subscribes to one of the current room's owners.

        // For the specified player, unequip anything which is equipped to the specified slot. If the slot is of Inventory type, this chip will take effect whether or not the slot is enabled.
        bool PlayerUnequipFromSlotR2(Player player, EquipmentSlot equipmentSlot, AlternativeExec<bool> onUnequipComplete);

        // For the target player, unequip the specified Inventory Item from any slot to which it is equipped.
        bool PlayerUnequipInventoryItemR2(Player player, InventoryItem inventoryItem, AlternativeExec<bool> onUnequipComplete);

        // Reads or writes a variable in the current scope based on the name.
        Player PlayerVariable(Player port1, VariableData config);

        // Reads or writes a variable in the current scope based on the name.

        // Define a set of world-space UI elements that can appear above a player.
        PlayerWorldUI PlayerWorldUI(PlayerWorldUIData config);

        // Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR.
        void PlayHandleHaptics(Handle handle, int duration, float intensity);

        // Multiplies a value by itself an input number of times.
        int Power(int value);

        // Multiplies a value by itself an input number of times.
        float Power(float value);

        // Print text to screen
        void PrintTextToScreen(TextScreen target, string text, Color color);

        // Projectile launcher fire projectile
        void ProjectileLauncherFireProjectile(ProjectileLauncher target, Vector3 direction);

        // Returns the player set by the Projectile Launcher Set Firing Player chip.
        Player ProjectileLauncherGetFiringPlayer(ProjectileLauncher target);

        // Projectile launcher get projectile count
        int ProjectileLauncherGetProjectileCount(ProjectileLauncher target);

        // Projectile launcher get projectile lifetime
        float ProjectileLauncherGetProjectileLifetime(ProjectileLauncher target);

        // Projectile launcher get projectile speed
        float ProjectileLauncherGetProjectileSpeed(ProjectileLauncher target);

        // Projectile launcher get projectile spread
        float ProjectileLauncherGetProjectileSpread(ProjectileLauncher target);

        // Sets the firing player of the target Projectile Launcher. If none is set, the component will use the authority player.
        void ProjectileLauncherSetFiringPlayer(ProjectileLauncher target, Player player);

        // Projectile launcher set projectile count
        void ProjectileLauncherSetProjectileCount(ProjectileLauncher target, int count);

        // Projectile launcher set projectile lifetime
        void ProjectileLauncherSetProjectileLifetime(ProjectileLauncher target, float lifetime);

        // Projectile launcher set projectile speed
        void ProjectileLauncherSetProjectileSpeed(ProjectileLauncher target, float speed);

        // Projectile launcher set projectile spread
        void ProjectileLauncherSetProjectileSpread(ProjectileLauncher target, float spread);

        // Sends a watch notification to a player. The player which it sends a notification to depends on who's machine fires the exec pin. Once this watch notification is opened, the player can type responses into the text box and send back responses. You can define the prompt title and the prompt itself via inputs, and can also receive the player’s response via an output pin.
        string PromptLocalPlayer(string promptTitle, string prompt, AlternativeExec<string> complete, AlternativeExec<string> failed);

        // Manually create a quaternion. Congratulations, you have reached peak math.
        Quaternion QuaternionCreate(float x, float y, float z, float w);

        // Creates a rotation which rotates "Angle" degrees around "Axis".
        Quaternion QuaternionCreateAngleAxis(float angle, Vector3 axis);

        // Creates a quaternion from an input Vector3.
        Quaternion QuaternionCreateEulerAngles(Vector3 angles);

        // Creates a rotation which rotates from "From" to "To".
        Quaternion QuaternionCreateFromTo(Vector3 from, Vector3 to);

        // Creates a rotation with the specified forward and upwards directions.
        Quaternion QuaternionCreateLook(Vector3 forward, Vector3 upwards);

        // The dot product between two rotations.
        float QuaternionDot(Quaternion lhs, Quaternion rhs);

        // Outputs the input quaternion as a vector3.
        Vector3 QuaternionEulerAngles(Quaternion value);

        // Gets the rotation which rotates angle degrees around axis.
        (float Angle, Vector3 Axis) QuaternionGetAngleAxis(Quaternion quaternion);

        // Outputs the Inverse of rotation.
        Quaternion QuaternionInverse(Quaternion value);

        // Outputs the input quaternion with the same rotation but with a magnitude of 1.
        Quaternion QuaternionNormalize(Quaternion value);

        // Rotates a rotation from "From" towards "To".
        Quaternion QuaternionRotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta);

        // Split a quaternion into its four float components: x, y, z, and w. Congratulations, you have reached peak math.
        (float X, float Y, float Z, float W) QuaternionSplit(Quaternion quaternion);

        // Reads or writes a variable in the current scope based on the name.
        Quaternion QuaternionVariable(Quaternion port1, VariableData config);

        // Configure this constant to add a set of custom Quick Chat phrases to your room, and enable them per-player with Quick Chat Table Set Enabled. Chat options will appear in the Quick Chat > This Room category.
        QuickChatTable QuickChatTable();

        // Enable or disable the specified Quick Chat Table for the specified player. If a different set of custom Quick Chat phrases is already enabled, this will overwrite it.
        void QuickChatTableSetEnabled(QuickChatTable target, Player player, bool enabled);

        // Generates a random float from ["Min" to "Max"]. "Min" is inclusive, and "Max" is also inclusive. For example with a "Min" of 0 and a "Max" of 1, both 0 and 1 have the possibility of getting output because they are both included in the range.
        float RandomFloat(float min, float max);

        // Outputs a random value from a target list.

        // Generates a random integer from ["Min" to "Max"]. "Min" is inclusive, and "Max" is also inclusive. For example with a "Min" of 0 and a "Max" of 1, 0 and 1 will have a chance of being output.
        int RandomInt(int min, int max);

        // Ranged weapon get color
        Color RangedWeaponGetColor(RangedWeapon target);

        // Ranged weapon get head damage
        int RangedWeaponGetHeadDamage(RangedWeapon target);

        // Ranged weapon get limb damage
        int RangedWeaponGetLimbDamage(RangedWeapon target);

        // Ranged weapon get projectile color
        Color RangedWeaponGetProjectileColor(RangedWeapon target);

        // Returns the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
        int RangedWeaponGetRecRoomObjectDamage(RangedWeapon target);

        // Ranged weapon get torso damage
        int RangedWeaponGetTorsoDamage(RangedWeapon target);

        // Ranged weapon set color
        void RangedWeaponSetColor(RangedWeapon target, Color color);

        // Ranged weapon set head damage
        void RangedWeaponSetHeadDamage(RangedWeapon target, int damage);

        // Ranged weapon set limb damage
        void RangedWeaponSetLimbDamage(RangedWeapon target, int damage);

        // Ranged weapon set projectile color
        void RangedWeaponSetProjectileColor(RangedWeapon target, Color color);

        // Sets the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
        void RangedWeaponSetRecRoomObjectDamage(RangedWeapon target, int damage);

        // Ranged weapon set torso damage
        void RangedWeaponSetTorsoDamage(RangedWeapon target, int damage);

        // Fires an invisible ray from the "Start Position", in the "Direction" specified. Returns True if any object or player is hit within the target "Max Distance". Otherwise, returns False. You can configure the chip itself to ignore players or objects specifically.
        (bool Hit, Player Player, RecRoomObject Object, float Distance, Vector3 HitPosition, Vector3 SurfaceNormal) Raycast(Vector3 startPosition, Vector3 direction, float maxDistance, RaycastData config);

        // Recalcualtes and updates the current room authority based on parameters such as their network connection and platform.
        bool RecalculateRoomAuthority();

        // Searches the room for all objects with the input tag and outputs a list of their direct children and all descendants in the hierarchy.

        // Searches the room for all objects with the input tag and outputs them as a list.

        // Searches the room for all objects with the input tag and outputs them as a list.
        // 
        // Objects are guaranteed to be returned in the same order for every player in an room. The order may change between instances of a room or when the room is reloaded.

        // Outputs the authority Player of the input object.
        Player RecRoomObjectGetAuthority(RecRoomObject target);

        // Gets the first object with the input tag.
        RecRoomObject RecRoomObjectGetFirstWithTag(string tag);

        // Gets the player currently holding this object. Does not account for when objects are equipped but not directly grabbed. Returns Invalid Player if the object is not being held.
        (bool IsHeld, Player HolderPlayer) RecRoomObjectGetHolderPlayer(RecRoomObject @object);

        // Outputs True on the player's machine who has authority of the input.
        bool RecRoomObjectGetIsLocalPlayerAuthority(RecRoomObject target);

        // Returns the player who last held or equipped an object.
        (Player Player, bool CurrentlyHeldOrEquipped) RecRoomObjectGetLastHoldingOrEquippingPlayer(RecRoomObject @object);

        // Rec room object get root object
        RecRoomObject RecRoomObjectGetRootObject(RecRoomObject targetObject);

        // Resets an object.
        void RecRoomObjectReset(RecRoomObject @object);

        // Sets the authority player of the input Rec Room Object.
        void RecRoomObjectSetAuthority(RecRoomObject target, Player authority);

        // Rec room object variable
        RecRoomObject RecRoomObjectVariable(RecRoomObject port1, VariableData config);

        // Outputs the remainder of the first value when divided by the second.
        int Remainder(params int[] value);

        // Outputs the remainder of the first value when divided by the second.
        float Remainder(params float[] value);

        // Remove a player from the radio channel they are in
        void RemovePlayerFromRadioChannel(Player player);

        // Removes a tag from the input object or player.
        void RemoveTag(Player target, string tag);

        // Removes a tag from the input object or player.
        void RemoveTag(RecRoomObject target, string tag);

        // Removes the input list of tags from the input object or player.
        void RemoveTags(Player target, List<string> tags);

        // Removes the input list of tags from the input object or player.
        void RemoveTags(RecRoomObject target, List<string> tags);

        // Returns the total number of objects that have been spawned by the target replicator and are currently active.
        int ReplicatorGetActiveObjectsCountR2(Replicator target);

        // Returns the list of objects that have been spawned by the target replicator and are currently active.

        // If the target object was spawned by a replicator, it will be despawned and returned to the pool. If not, the chip will no-op.
        void ReplicatorReturnObjectR2(RecRoomObject target);

        // Spawns a copy of the object assigned to the target replicator at the position and orientation specified. If “Assign to Player” is true, the resulting object will be assigned to the specified player such that no other players can interact with it, and the object will be automatically returned when that player leaves the room.
        // 
        // When the object is spawned, On Spawn Complete will fire and pass through an object reference. If it fails, such as when the limit of objects has been hit, the object reference will be invalid and the Success bool will be false.
        (RecRoomObject Object, bool Success) ReplicatorSpawnNextObjectR2(Replicator target, Vector3 position, Quaternion orientation, bool assignToPlayer, Player player, AlternativeExec<(RecRoomObject Object, bool Success);

        // Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        void RequestVelocitySetOverDuration(Player @object, float multiplier, Vector3 velocity, float duration);

        // Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        void RequestVelocitySetOverDuration(RecRoomObject @object, float multiplier, Vector3 velocity, float duration);

        // Used to remove spaghetti from your creations. Consumes additional CPU heat.

        // Reset the player's active world UI to its default values.
        void ResetPlayerWorldUI(Player player);

        // Resets the Room.
        void ResetRoom();

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool Respawn(Player target, Vector3 position, Vector3 rotation, float spawnRadius, bool clearVelocity, bool useRezEffects);

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool Respawn(Player target, Vector3 position, Quaternion rotation, float spawnRadius, bool clearVelocity, bool useRezEffects);

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool Respawn(RecRoomObject target, Vector3 position, Vector3 rotation, float spawnRadius, bool clearVelocity, bool useRezEffects);

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool Respawn(RecRoomObject target, Vector3 position, Quaternion rotation, float spawnRadius, bool clearVelocity, bool useRezEffects);

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.

        // Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.

        // Respawn point add avoid role r1
        bool RespawnPointAddAvoidRoleR1(PlayerSpawnPointV2 spawnPoint, string role);

        // Respawn point add avoid tag
        void RespawnPointAddAvoidTag(PlayerSpawnPointV2 spawnPoint, string tag);

        // Respawn point add spawn role r1
        bool RespawnPointAddSpawnRoleR1(PlayerSpawnPointV2 spawnPoint, string role);

        // Respawn point add spawn tag
        void RespawnPointAddSpawnTag(PlayerSpawnPointV2 spawnPoint, string tag);

        // Respawn point get active
        bool RespawnPointGetActive(PlayerSpawnPointV2 target);

        // Respawn point remove avoid role r1
        void RespawnPointRemoveAvoidRoleR1(PlayerSpawnPointV2 spawnPoint, string role);

        // Respawn point remove avoid tag
        void RespawnPointRemoveAvoidTag(PlayerSpawnPointV2 spawnPoint, string tag);

        // Respawn point remove spawn role r1
        void RespawnPointRemoveSpawnRoleR1(PlayerSpawnPointV2 spawnPoint, string role);

        // Respawn point remove spawn tag
        void RespawnPointRemoveSpawnTag(PlayerSpawnPointV2 spawnPoint, string tag);

        // Respawn point respawn player
        void RespawnPointRespawnPlayer(Player player, bool clearVelocity, bool useRezEffects);

        // Respawn point respawn player at respawn point
        void RespawnPointRespawnPlayerAtRespawnPoint(PlayerSpawnPointV2 spawnPoint, Player player, bool clearVelocity, bool useRezEffects);

        // Respawn point set active
        void RespawnPointSetActive(PlayerSpawnPointV2 target, bool active);

        // Get a reference to a single Reward. Rewards can be created in the Rewards tab of the Room Settings menu
        Reward Reward();

        // Return a color from the given red, green, and blue inputs. All inputs are in the range [0, 1].
        Color RGBToColor(float red, float green, float blue);

        // Clears the given player's local room background objects state override.
        void RoomBackgroundObjectsClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished);

        // Room background objects modify r1
        bool RoomBackgroundObjectsModifyR1(BackgroundObjects backgroundObjectsConstant, AlternativeExec<bool> blendFinished);

        // Changes the room's shared background objects state to the given configuration.
        void RoomBackgroundObjectsModifyR2(BackgroundObjects backgroundObjects, float blendTime, AlternativeExec blendFinished);

        // Overrides the given player's room background objects state to the given configuration. This will take precedent over the room's shared background objects state.
        void RoomBackgroundObjectsPlayerOverrideR2(BackgroundObjects backgroundObjects, Player player, float blendTime, AlternativeExec blendFinished);

        // Room background objects reset r1
        void RoomBackgroundObjectsResetR1(AlternativeExec blendFinished);

        // Resets the room's shared background objects state to the room default.
        void RoomBackgroundObjectsResetR2(float blendTime, AlternativeExec blendFinished);

        // Room currency constant r1
        RoomCurrency RoomCurrencyConstantR1(RoomCurrencyData config);

        // Clears the given player's local room fog state override.
        void RoomFogClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished);

        // Room fog modify r1
        bool RoomFogModifyR1(Fog fogConstant, AlternativeExec<bool> blendFinished);

        // Changes the room's shared fog state to the given configuration.
        void RoomFogModifyR2(Fog fog, float blendTime, AlternativeExec blendFinished);

        // Overrides the given player's room fog state to the given configuration. This will take precedent over the room's shared fog state.
        void RoomFogPlayerOverrideR2(Fog fog, Player player, float blendTime, AlternativeExec blendFinished);

        // Room fog reset r1
        void RoomFogResetR1(AlternativeExec blendFinished);

        // Resets the room's shared fog state to the room default.
        void RoomFogResetR2(float blendTime, AlternativeExec blendFinished);

        // Room get matchmaking state
        bool RoomGetMatchmakingState();

        // Returns the player in the room with this unique index, bounded by the room capacity.
        Player RoomIndexGetPlayer(int roomIndex);

        // Room key constant r1
        RoomKey RoomKeyConstantR1(RoomKeyData config);

        // HUD elements including progress bars, wheels, and counters. Configure to customize a single element, then enable & modify with existing HUD chips. Can be configured to pull data from Room Progression if Progression is enabled in room settings.
        RoomLevelHUD RoomLevelHUD();

        // A specialized data table for use with Room Progression, with some cells and formatting choices reserved. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room via Data Table UI to commit changes.
        void RoomLevels(object levels);

        // Room offer constant r2
        RoomOffer RoomOfferConstantR2();

        // Room set matchmaking state
        bool RoomSetMatchmakingState(bool matchmakingPermitted, AlternativeExec<bool> onMatchmakingStateSet);

        // Clears the given player's local room skydome state override.
        void RoomSkydomeClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished);

        // Room skydome modify r1
        bool RoomSkydomeModifyR1(Skydome skydomeConstant, AlternativeExec<bool> blendFinished);

        // Changes the room's shared skydome state to the given configuration.
        void RoomSkydomeModifyR2(Skydome skydome, float blendTime, AlternativeExec blendFinished);

        // Overrides the given player's room skydome state to the given configuration. This will take precedent over the room's shared skydome state.
        void RoomSkydomePlayerOverrideR2(Skydome skydome, Player player, float blendTime, AlternativeExec blendFinished);

        // Room skydome reset r1
        void RoomSkydomeResetR1(AlternativeExec blendFinished);

        // Resets the room's shared skydome state to the room default.
        void RoomSkydomeResetR2(float blendTime, AlternativeExec blendFinished);

        // Clears the given player's local room sun state override.
        void RoomSunClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished);

        // Room sun modify r1
        bool RoomSunModifyR1(Sun sunConstant, SunDirection sunDirection, AlternativeExec<bool> blendFinished);

        // Changes the room's shared sun state to the given configuration.
        void RoomSunModifyR2(Sun sun, SunDirection sunDirection, float blendTime, AlternativeExec blendFinished);

        // Overrides the given player's room sun state to the given configuration. This will take precedent over the room's shared sun state.
        void RoomSunPlayerOverrideR2(Sun sun, SunDirection sunDirection, Player player, float blendTime, AlternativeExec blendFinished);

        // Room sun reset r1
        void RoomSunResetR1(AlternativeExec blendFinished);

        // Resets the room's shared sun state to the room default.
        void RoomSunResetR2(float blendTime, AlternativeExec blendFinished);

        // Calculate the root of a given value, with the default root being 2 (meaning the square root).
        float Root(float value, float root);

        // Root object
        RecRoomObject RootObject();

        // Root player
        Player RootPlayer();

        // Rotate a Vector3 with a Quaternion.
        Vector3 RotateVector(Quaternion rotation, Vector3 point);

        // Outputs the rotation of a target Rotator in degrees.
        float RotatorGetRotation(Rotator target);

        // Outputs the acceleration of a target Rotator.
        float RotatorGetRotationAcceleration(Rotator target);

        // Outputs the speed of a target Rotator.
        float RotatorGetRotationSpeed(Rotator target);

        // Outputs the rotation of the Marker on the target Rotator.
        float RotatorGetTargetRotation(Rotator target);

        // Sets the rotation of a target Rotator.
        void RotatorSetRotation(Rotator target, float value);

        // Sets the acceleration of a target Rotator.
        void RotatorSetRotationAcceleration(Rotator target, float value);

        // Sets the speed of a target Rotator.
        void RotatorSetRotationSpeed(Rotator target, float value);

        // Sets the rotation of the Marker on a target Rotator.
        void RotatorSetTargetRotation(Rotator target, float value);

        // Rounds the input float to the nearest integral value.
        float Round(float value);

        // Rounds an input value to the nearest integer.
        int RoundToInt(float value);

        // Record and store custom a custom audio sample, for use with the Audio Player.
        Audio SampleAudioConstant();

        // Returns True if the target Seat is set to lock players in.
        bool SeatGetLockPlayersIn(Seat target);

        // Returns True if the target Seat is set to lock players out.
        bool SeatGetLockPlayersOut(Seat target);

        // Outputs the currently seated player of a target Seat.
        Player SeatGetSeatedPlayer(Seat target);

        // Prevents a Seated player from unseating themselves on a target Seat. Use circuits to unseat or unlock.
        void SeatSetLockPlayersIn(Seat target, bool lockPlayersIn);

        // Prevents players from sitting in a target seat.
        void SeatSetLockPlayersOut(Seat target, bool lockPlayersOut);

        // Seats an input player on a target Seat.
        void SeatSetSeatedPlayer(Seat target, Player player, AlternativeExec fail);

        // Unseats a currently seated player on a target Seat.
        void SeatUnseatPlayer(Seat target);

        // Outputs the object of the current context. For example, a self node inside a light outputs that specific light of the light type. This can only be placed inside an object board of a specific object or a player or object definition board.
        int Self();

        // Executes all output ports in order.

        // Start a screen shake effect for the given player. This will have no effect on VR players.
        void SetCameraShake(Player player, float intensity, float duration);

        // Set h u d element color
        void SetHUDElementColor(HUDConstant target, Color color);

        // Override all Game HUD Element properties using default values from Game HUD Element Constant input
        void SetHUDElementContent(HUDConstant target);

        // Set h u d element enabled
        void SetHUDElementEnabled(HUDConstant target, bool enabled);

        // Set h u d element label
        void SetHUDElementLabel(HUDConstant target, string label);

        // Set h u d element label enabled
        void SetHUDElementLabelEnabled(HUDConstant target, bool enabled);

        // Set h u d element max value
        void SetHUDElementMaxValue(HUDConstant target, int value);

        // Set h u d element value
        void SetHUDElementValue(HUDConstant target, int value);

        // Set h u d element value text enabled
        void SetHUDElementValueTextEnabled(HUDConstant target, bool enabled);

        // Apply a vignette of the given color to the given player. The vignette will be displayed at the given intensity for the given duration, and then fade out. The intensity must be between 0 and 1.
        void SetPlayerVignette(Player player, float time, Color color, float intensity);

        // Set the color of the primary bar in the given player's active world UI.
        void SetPlayerWorldUIPrimaryBarColor(Player player, Color color);

        // Set the enabled state of the primary bar in the given player's active world UI.
        void SetPlayerWorldUIPrimaryBarEnabled(Player player, bool enabled);

        // Set the max value of the primary bar in the given player's active world UI.
        void SetPlayerWorldUIPrimaryBarMaxValue(Player player, int value);

        // Set the value of the primary bar in the given player's active world UI.
        void SetPlayerWorldUIPrimaryBarValue(Player player, int value);

        // Set the color of the secondary bar in the given player's active world UI.
        void SetPlayerWorldUISecondaryBarColor(Player player, Color color);

        // Set the enabled state of the secondary bar in the given player's active world UI.
        void SetPlayerWorldUISecondaryBarEnabled(Player player, bool enabled);

        // Set the max value of the secondary bar in the given player's active world UI.
        void SetPlayerWorldUISecondaryBarMaxValue(Player player, int value);

        // Set the value of the secondary bar in the given player's active world UI.
        void SetPlayerWorldUISecondaryBarValue(Player player, int value);

        // Set the color of the text in the given player's active world UI.
        void SetPlayerWorldUITextColor(Player player, Color color);

        // Set the enabled state of the text in the given player's active world UI.
        void SetPlayerWorldUITextEnabled(Player player, bool enabled);

        // Set the value of the text in the given player's active world UI.
        void SetPlayerWorldUITextValue(Player player, string value);

        // Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetPosition(Player target, Vector3 position);

        // Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetPosition(RecRoomObject target, Vector3 position);

        // Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.

        // Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.

        // Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetPositionInReferenceObjectSpace(Player target, Vector3 position, Player referenceObject);

        // Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetPositionInReferenceObjectSpace(Player target, Vector3 position, RecRoomObject referenceObject);

        // Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetPositionInReferenceObjectSpace(RecRoomObject target, Vector3 position, Player referenceObject);

        // Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetPositionInReferenceObjectSpace(RecRoomObject target, Vector3 position, RecRoomObject referenceObject);

        // Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetRotation(Player target, Vector3 rotation);

        // Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetRotation(Player target, Quaternion rotation);

        // Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetRotation(RecRoomObject target, Vector3 rotation);

        // Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetRotation(RecRoomObject target, Quaternion rotation);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(Player target, Vector3 rotation, Player referenceObject);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(Player target, Vector3 rotation, RecRoomObject referenceObject);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(Player target, Quaternion rotation, Player referenceObject);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(Player target, Quaternion rotation, RecRoomObject referenceObject);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(RecRoomObject target, Vector3 rotation, Player referenceObject);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(RecRoomObject target, Vector3 rotation, RecRoomObject referenceObject);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(RecRoomObject target, Quaternion rotation, Player referenceObject);

        // Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetRotationInReferenceObjectSpace(RecRoomObject target, Quaternion rotation, RecRoomObject referenceObject);

        // Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetTransform(Player target, Vector3 position, Vector3 rotation);

        // Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetTransform(Player target, Vector3 position, Quaternion rotation);

        // Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetTransform(RecRoomObject target, Vector3 position, Vector3 rotation);

        // Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        bool SetTransform(RecRoomObject target, Vector3 position, Quaternion rotation);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Vector3 rotation, Player referenceObject);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Vector3 rotation, RecRoomObject referenceObject);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Quaternion rotation, Player referenceObject);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Quaternion rotation, RecRoomObject referenceObject);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Vector3 rotation, Player referenceObject);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Vector3 rotation, RecRoomObject referenceObject);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Quaternion rotation, Player referenceObject);

        // Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.
        bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Quaternion rotation, RecRoomObject referenceObject);

        // Choose from a selection of SFX, for use with the Audio Player.
        Audio SFXConstant(SFXConstantData config);

        // S f x get is playing
        bool SFXGetIsPlaying(SFX target);

        // Outputs the volume of an SFX object.
        int SFXGetVolume(SFX target);

        // Plays a sound from an SFX object.
        void SFXPlay(SFX target);

        // Sets the volume for an SFX object.
        void SFXSetVolume(SFX target, int value);

        // Stops the sound currently playing from an SFX object.
        void SFXStop(SFX target);

        // Gets whether the target player has their Share Camera spawned
        bool ShareCameraGetIsSpawned(Player player);

        // Shows a player a banner notification. Appearance can be customized in the config menu!
        void ShowBannerNotification(Player player, string title, string mainText, float duration);

        // Prints the input notification to the given player's screen.

        // Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        void ShowPurchasePromptR1(RoomKey inRoomPurchasable, Player player);

        // Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        void ShowPurchasePromptR1(Consumable inRoomPurchasable, Player player);

        // Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        void ShowPurchasePromptR1(RoomCurrency inRoomPurchasable, Player player);

        // Show purchase prompt r2
        void ShowPurchasePromptR2(RoomOffer inRoomPurchasable, Player player);

        // Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        void ShowRewardNotification(Player player, Reward reward, float duration);

        // Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        void ShowRewardNotification(Player player, List<Reward> reward, float duration);

        // Computes the sine of a number.
        float Sin(float value);

        // Defines values for the room skydome.
        Skydome SkydomeConstant();

        // Spherically interpolates between quaternions or Vector3s "Start" and "End". Progress is 0 to 1. Also a rare, but refreshing beverage.
        Quaternion Slerp(Quaternion start, Quaternion end, float progress);

        // Spherically interpolates between quaternions or Vector3s "Start" and "End". Progress is 0 to 1. Also a rare, but refreshing beverage.
        Vector3 Slerp(Vector3 start, Vector3 end, float progress);

        // Moves a vector towards a target, with velocity based damping
        (float Result, float ResultVelocity) SmoothDamp(float current, float target, float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);

        // Moves a vector towards a target, with velocity based damping
        (Vector3 Result, Vector3 ResultVelocity) SmoothDamp(Vector3 current, Vector3 target, Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime);

        // Spawner internal start spawning r1
        void SpawnerInternalStartSpawningR1(RecRoomObject spawner, int amountOfObjectsToSpawn, float timeBetweenSpawns, Vector3 spawnPosition);

        // Spawner reset r1
        void SpawnerResetR1(RecRoomObject port1);

        // Fires an invisible sphere of the specified Radius from the Start Position, in the Direction specified. Returns true if any object or player is hit within the target Max Distance. Otherwise, returns false. You can configure the chip itself to ignore players or objects specifically.
        (bool Hit, Player Player, RecRoomObject Object, float Distance, Vector3 HitPosition, Vector3 SurfaceNormal) Spherecast(Vector3 startPosition, float radius, Vector3 direction, float maxDistance, RaycastData config);

        // Place this chip inside a State Machine chip to represent a state.
        void State();

        // A constant representing a state in a state machine.
        State StateConstant();

        // Manage state transitions by editing into this chip and populating it with connected State chips.
        void StateMachine();

        // Stop any current screen shake for the given player.
        void StopCameraShake(Player player);

        // Storefront get is enabled r2
        bool StorefrontGetIsEnabledR2(Storefront storefront);

        // Storefront set is enabled r2
        void StorefrontSetIsEnabledR2(Storefront storefront, bool isEnabled);

        // Storefront set offers list r2
        void StorefrontSetOffersListR2(Storefront storefront, List<RoomOffer> offersList);

        // Concatenate a given series of strings in order, with an optional separator.
        string StringConcat(params string[] separator);

        // Outputs True if the target string contains the input value.
        bool StringContains(string @string, string sequence);

        // Use this chip to combine multiple strings together into a single string output. The "Format" input is part of final string output and can include other string inputs by using this syntax: {input pin # starting at 0}. For example, a "Format" input with a default value of “Hello, {0}!” with a single additional input pin with the value "World" is fully output as "Hello, World!". If you had another input pin you would use {1} to denote the 2nd pin. You can add more string inputs by configuring the chip and pressing "Add Input".
        string StringFormat(string format, string value);

        // Outputs the index where the substring starts in the target string.
        int StringIndexOf(string @string, string substring);

        // Outputs the length of a target string in UTF-16 characters.
        int StringLength(string @string);

        // Replaces all instances of pattern within string with replacement.
        string StringReplace(string @string, string pattern, string replacement);

        // Splits the target string at the input character.

        // Splits the target string in two at the input index.

        // Outputs a list of strings which split up by whitespace.

        // Allows you to extract individual parts from a string. You can think of this like a list of characters.
        string StringSubstring(string @string, int index, int length);

        // Outputs the target string in lower case.
        string StringToLower(string @string);

        // Outputs the target string in upper case.
        string StringToUpper(string @string);

        // Outputs the string with leading and trailing whitespace removed.
        string StringTrim(string @string);

        // Reads or writes a variable in the current scope based on the name.
        string StringVariable(string port1, VariableData config);

        // Studio audio constant
        Audio StudioAudioConstant(SFXConstantData config);

        // Studio event sender
        void StudioEventSender(StudioObject studioObject, string @event);

        // Studio event sender bool
        void StudioEventSenderBool(StudioObject studioObject, string @event, bool value);

        // Studio event sender float
        void StudioEventSenderFloat(StudioObject studioObject, string @event, float value);

        // Studio event sender int
        void StudioEventSenderInt(StudioObject studioObject, string @event, int value);

        // Studio event sender string
        void StudioEventSenderString(StudioObject studioObject, string @event, string value);

        // Studio event sender string bool
        void StudioEventSenderStringBool(StudioObject studioObject, string @event, string value0, bool value1);

        // Studio event sender string float
        void StudioEventSenderStringFloat(StudioObject studioObject, string @event, string value0, float value1);

        // Studio event sender string int
        void StudioEventSenderStringInt(StudioObject studioObject, string @event, string value0, int value1);

        // Studio event sender string string
        void StudioEventSenderStringString(StudioObject studioObject, string @event, string value0, string value1);

        // Studio function
        void StudioFunction(StudioObject studioObject, StudioFunctionData config);

        // Studio object get property bool
        bool StudioObjectGetPropertyBool(StudioObject studioObject, string property);

        // Studio object get property color
        Color StudioObjectGetPropertyColor(StudioObject studioObject, string property);

        // Studio object get property float
        float StudioObjectGetPropertyFloat(StudioObject studioObject, string property);

        // Studio object get property int
        int StudioObjectGetPropertyInt(StudioObject studioObject, string property);

        // Studio object get property quaternion
        Quaternion StudioObjectGetPropertyQuaternion(StudioObject studioObject, string property);

        // Studio object get property string
        string StudioObjectGetPropertyString(StudioObject studioObject, string property);

        // Studio object get property vector3
        Vector3 StudioObjectGetPropertyVector3(StudioObject studioObject, string property);

        // Takes one input value away from the other.
        int Subtract(params int[] value);

        // Takes one input value away from the other.
        float Subtract(params float[] value);

        // Takes one input value away from the other.
        Vector3 Subtract(params Vector3[] value);

        // Defines values for the room's sun.
        Sun SunConstant();

        // Swing handle get is swinging
        bool SwingHandleGetIsSwinging(SwingHandle target);

        // Computes the tangent of a number.
        float Tan(float value);

        // Returns the color of the target Text gadget.
        Color TextGetColor(Text target);

        // Outputs the visible text for a Text object.
        string TextGetText(Text target);

        // Sets the color for a Text object.
        void TextSetColor(Text target, Color color);

        // Sets the color for a Text object.

        // Sets the material for a Text object.
        void TextSetMaterial(Text target, int material);

        // Set the visible text for a Text object.
        void TextSetText(Text target, string text);

        // Gets the amount of seconds since a player launched Rec Room.
        float TimeGetPreciseSeconds();

        // Gets the number of seconds since 1970. Uses server's clock. This will be synchronized between players. This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
        int TimeGetUniversalSeconds();

        // Gets the UTC time. Uses server's clock. This will be synchronized between players.
        (int Year, int Month, int Day, int Hour, int Minute, int Second) TimeGetUniversalTime();

        // Gets the number of seconds since 1970. Uses local player's system clock. This is not synchronized between players! This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
        int TimeGetUnsyncedUniversalSeconds();

        // Gets the UTC time. Uses local player's system clock. This is not synchronized between players!
        (int Year, int Month, int Day, int Hour, int Minute, int Second) TimeGetUnsyncedUniversalTime();

        // Covert a player or an AI value into a Combatant value.
        Combatant ToCombatantR1(AI playerOrAI);

        // Covert a player or an AI value into a Combatant value.
        Combatant ToCombatantR1(Player playerOrAI);

        // Outputs True if the toggle button is pressed.
        bool ToggleButtonGetIsPressed(ToggleButton target);

        // Sets a Toggle Button state to pressed.
        void ToggleButtonSetIsPressed(ToggleButton target, bool value);

        // Sets a Toggle Button state to pressed.

        // Casts a target specific object to a Rec Room Object.

        // Converts the input value to the string type. Example: the integer input 10 would output "10" as a string. Helpful for debugging purposes.

        // Converts the input value to the string type. Example: the integer input 10 would output "10" as a string. Helpful for debugging purposes.

        // Get the active touch position from the local player's interaction
        (bool IsTouchActive, Vector3 TouchPosition, Vector3 WorldPosition) TouchpadComponentGetActiveTouch(Touchpad target);

        // Sets the interaction label (used by Screen players)
        string TouchpadComponentGetInteractionLabel(Touchpad target);

        // Sets if the Touchpad can be interacted with or output touch events
        bool TouchpadComponentGetIsEnabled(Touchpad target);

        // Gets the interaction label (used by Screen players)
        void TouchpadComponentSetInteractionLabel(Touchpad target, string label);

        // Gets if the Touchpad can be interacted with or output touch events
        void TouchpadComponentSetIsEnabled(Touchpad target, bool enabled);

        // Returns the color of the target Motion Trail object.
        Color TrailGetColor(MotionTrail target);

        // Outputs True if the target Motion Trail object is enabled.
        bool TrailGetEnabled(MotionTrail target);

        // Returns the lifetime of the target Motion Trail object.
        float TrailGetLifetime(MotionTrail target);

        // Returns the max opacity of the target Motion Trail object.
        float TrailGetOpacity(MotionTrail target);

        // Sets the color of the target Motion Trail object.
        void TrailSetColor(MotionTrail target, Color color);

        // Sets the enabled state of the target Motion Trail object.
        void TrailSetEnabled(MotionTrail target, bool enabled);

        // Sets the lifetime of the target Motion Trail object.
        void TrailSetLifetime(MotionTrail target, float lifetime);

        // Sets the max opacity of the target Motion Trail object.
        void TrailSetOpacity(MotionTrail target, float maxOpacity);

        // True if the primary action button is down; otherwise, False.
        bool TriggerHandleGetPrimaryActionHeld(TriggerHandle target);

        // Gets the role name that is being used as a filter for a Trigger Volume.
        string TriggerVolumeGetFilterRoleR1(TriggerVolume target);

        // Gets the number of objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
        int TriggerVolumeGetObjectCount(TriggerVolume target);

        // Gets the tags that are being used as the object filter for a Trigger Volume.

        // Gets all of the objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!

        // Gets the number of players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
        int TriggerVolumeGetPlayerCount(TriggerVolume target);

        // Gets the tags that are being used as the player filter for a Trigger Volume.

        // Gets all of the players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!

        // Sets the role name that is being used as a filter for a Trigger Volume.
        void TriggerVolumeSetFilterRoleR1(TriggerVolume target, string value);

        // Sets the tags that are being used as the object filter for a Trigger Volume. An object is considered by the Trigger Volume, if it has any of the tags in this list.
        void TriggerVolumeSetObjectFilterTags(TriggerVolume target, List<string> tags);

        // Sets the tags that are being used as the player filter for a Trigger  Volume. A player is considered by the Trigger Volume, if they have any of the tags in this list.
        void TriggerVolumeSetPlayerFilterTagsR2(TriggerVolume target, List<string> tags);

        // Unequip from player
        bool UnequipFromPlayer(Player player, RecRoomObject @object);

        // Unequip object
        bool UnequipObject(RecRoomObject @object);

        // Returns the associated input of the compare value that matches the 'match' input. Returns the default value if no match can be found.

        // Returns the associated input of the compare value that matches the 'match' input. Returns the default value if no match can be found.

        // Clamps a vector's magnitude to a given max length.
        // Vector is unchanged if magnitude is already less.
        // Max length cannot be negative.
        Vector3 Vector3ClampMagnitude(Vector3 vector, float maxLength);

        // Gets the point on the plane that is closest to a given position
        Vector3 Vector3ClosestPointOnPlane(Vector3 position, Vector3 planePosition, Vector3 planeNormal);

        // Creates a new vector from X, Y, Z values.
        Vector3 Vector3Create(float x, float y, float z);

        // The cross product of two vectors results in a third vector which is perpendicular to the two input vectors.
        Vector3 Vector3Cross(Vector3 lhs, Vector3 rhs);

        // Computes the dot product. Commonly used to determine if the camera is facing a particular direction.
        float Vector3Dot(Vector3 lhs, Vector3 rhs);

        // Multiplies a vector by -1 to get its inverse.
        Vector3 Vector3Inverse(Vector3 value);

        // Vector3 inverse transform
        Vector3 Vector3InverseTransform(Vector3 worldPoint, Vector3 worldOrigin, Quaternion worldOrientation);

        // Moves a vector towards target, not moving more than max delta distance at a time
        Vector3 Vector3MoveTowards(Vector3 current, Vector3 target, float maxDelta);

        // Outputs the target vector, but its magnitude is 1.
        Vector3 Vector3Normalize(Vector3 value);

        // Projects a vector onto a normal
        Vector3 Vector3Project(Vector3 vector, Vector3 onNormal);

        // Projects a vector onto a plane
        Vector3 Vector3ProjectOnPlane(Vector3 vector, Vector3 planeNormal);

        // Multiplies a vector by a scalar.
        Vector3 Vector3Scale(Vector3 value, int scalar);

        // Multiplies a vector by a scalar.
        Vector3 Vector3Scale(Vector3 value, float scalar);

        // Breaks the X, Y, and Z values out of the input vector.
        (float X, float Y, float Z) Vector3Split(Vector3 vector3);

        // Vector3 transform
        Vector3 Vector3Transform(Vector3 localPoint, Vector3 worldOrigin, Quaternion worldOrientation);

        // Reads or writes a variable in the current scope based on the name.
        Vector3 Vector3Variable(Vector3 port1, VariableData config);

        // Gets the direction and magnitude of the Vector Component.
        Vector3 VectorComponentGetVector(VectorComponent direction, float magnitude);

        // Outputs the length of the input vector.
        float VectorGetMagnitude(Vector3 vector3);

        // Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        void VelocityAdd(Player target, float multiplier, Vector3 velocity, float maximumSpeed);

        // Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        void VelocityAdd(RecRoomObject target, float multiplier, Vector3 velocity, float maximumSpeed);

        // Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.

        // Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.

        // The input target's velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        void VelocityReflect(Player target, float additionalSpeed, float speedMultiplier, Vector3 direction, float maximumSpeed);

        // The input target's velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        void VelocityReflect(RecRoomObject target, float additionalSpeed, float speedMultiplier, Vector3 direction, float maximumSpeed);

        // Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        void VelocitySet(Player target, float multiplier, Vector3 velocity);

        // Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        void VelocitySet(RecRoomObject target, float multiplier, Vector3 velocity);

        // Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.

        // Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.

        // Return whether target welcome mat is enabled (true) or disabled (false)
        bool WelcomeMatGetEnabled(WelcomeMat target);

        // Set target welcome mat to be enabled (true) or disabled (false)
        void WelcomeMatSetEnabled(WelcomeMat target, bool enabled);

        // Xor
        bool Xor(bool input);
    }
}
*/
