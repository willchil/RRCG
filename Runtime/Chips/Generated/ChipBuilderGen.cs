using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;
using RRCG;

namespace RRCGGenerated
{
    public class ChipBuilderGen
    {
        public static FloatPort AbsoluteValue(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Absolute Value", Type = "98b99011-9be8-43b3-89cc-1e9d55bd8b51", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort AbsoluteValue(IntPort Value)
        {
            Node node = new Node()
            {Name = "Absolute Value", Type = "98b99011-9be8-43b3-89cc-1e9d55bd8b51", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Acos(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Acos", Type = "46ce50b8-0a20-43d2-9646-484ce2a6752c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Add(IntPort Value)
        {
            Node node = new Node()
            {Name = "Add", Type = "0ccb153c-dd08-4f22-80fd-9d8c5940928c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Add(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Add", Type = "0ccb153c-dd08-4f22-80fd-9d8c5940928c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Add(Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Add", Type = "0ccb153c-dd08-4f22-80fd-9d8c5940928c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AddTag(PlayerPort Target, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Add Tag", Type = "953fb21b-c9f0-46fc-a0f1-ee1a937854f8", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AddTag(RecRoomObjectPort Target, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Add Tag", Type = "953fb21b-c9f0-46fc-a0f1-ee1a937854f8", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AddTags(PlayerPort Target, ListPort<StringPort> Tags)
        {
            Node node = new Node()
            {Name = "Add Tags", Type = "81939b0e-428f-481c-9fba-453b4c84f01e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AddTags(RecRoomObjectPort Target, ListPort<StringPort> Tags)
        {
            Node node = new Node()
            {Name = "Add Tags", Type = "81939b0e-428f-481c-9fba-453b4c84f01e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange) AIGetLineOfSightParameters(AIPort AI)
        {
            Node node = new Node()
            {Name = "AI Get Line of Sight Parameters", Type = "3edc785f-46ef-4f30-b101-a07126d3a370", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static CombatantPort AIGetTarget(AIPort AI)
        {
            Node node = new Node()
            {Name = "AI Get Target", Type = "1637b250-e497-4f4a-9d5e-64206488391c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTarget(AIPort AI, AIPort Target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTarget(AIPort AI, CombatantPort Target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTarget(AIPort AI, RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTarget(AIPort AI, PatrolPointPort Target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTarget(AIPort AI, PlayerPort Target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTarget(AIPort AI, Vector3Port Target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AILookAt(AIPort AI, AIPort LookTarget, BoolPort LookTargetisDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, LookTargetisDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAt(AIPort AI, CombatantPort LookTarget, BoolPort LookTargetisDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, LookTargetisDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAt(AIPort AI, RecRoomObjectPort LookTarget, BoolPort LookTargetisDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, LookTargetisDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAt(AIPort AI, PatrolPointPort LookTarget, BoolPort LookTargetisDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, LookTargetisDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAt(AIPort AI, PlayerPort LookTarget, BoolPort LookTargetisDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, LookTargetisDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAt(AIPort AI, Vector3Port LookTarget, BoolPort LookTargetisDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, LookTargetisDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathTo(AIPort AI, AIPort Target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathTo(AIPort AI, CombatantPort Target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathTo(AIPort AI, RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathTo(AIPort AI, PatrolPointPort Target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathTo(AIPort AI, PlayerPort Target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathTo(AIPort AI, Vector3Port Target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIRotate(AIPort AI, FloatPort Rotation)
        {
            Node node = new Node()
            {Name = "AI Rotate", Type = "c2cb2ea2-f663-4aa6-9394-3b741f6b9064", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIRotate(AIPort AI, IntPort Rotation)
        {
            Node node = new Node()
            {Name = "AI Rotate", Type = "c2cb2ea2-f663-4aa6-9394-3b741f6b9064", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIRotate(AIPort AI, Vector3Port Rotation)
        {
            Node node = new Node()
            {Name = "AI Rotate", Type = "c2cb2ea2-f663-4aa6-9394-3b741f6b9064", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetLineOfSightParameters(AIPort AI, StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange, BoolPort RequireLoSfortargeting)
        {
            Node node = new Node()
            {Name = "AI Set Line of Sight Parameters", Type = "02557d1f-2265-4b6d-8177-92f1802dc106", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, VisionType, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, VisionRange, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, VisionConeAngle, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, HearingRange, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, RequireLoSfortargeting, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetPathingSpeed(AIPort AI, FloatPort Speed)
        {
            Node node = new Node()
            {Name = "AI Set Pathing Speed", Type = "cd85a0c7-789b-41a2-aeda-40925b73738c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetPatrolPoint(AIPort AI, PatrolPointPort PatrolPoint)
        {
            Node node = new Node()
            {Name = "AI Set Patrol Point", Type = "6370b8d9-8c72-4e6b-a623-acb7202a3110", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, PatrolPoint, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetTarget(AIPort AI, CombatantPort Target)
        {
            Node node = new Node()
            {Name = "AI Set Target", Type = "73652899-2656-4aa4-a1b0-4de8d8e56095", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIStartCombatBehavior(AIPort AI)
        {
            Node node = new Node()
            {Name = "AI Start Combat Behavior", Type = "b169c26e-3c2c-4058-bae7-dbbc3ee856a4", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIStopCombatBehavior(AIPort AI)
        {
            Node node = new Node()
            {Name = "AI Stop Combat Behavior", Type = "6e244bf2-cf71-4baa-912d-3e61c7fcd1be", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIStopLooking(AIPort AI)
        {
            Node node = new Node()
            {Name = "AI Stop Looking", Type = "f211a503-a237-41bc-875e-ae3ef62d745b", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, AI, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static AIPort AIVariable(AIPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "AI Variable", Type = "0e92a7fb-fb38-418c-af39-9afec92112ee", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new AIPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static AudioPort AmbienceConstant()
        {
            Node node = new Node()
            {Name = "Ambience Constant", Type = "1ad615de-65ea-40a3-b500-3a5b56b2a65d", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static BoolPort And(BoolPort Input)
        {
            Node node = new Node()
            {Name = "And", Type = "3fb9fd93-8d45-4395-b9a3-63a99a14442b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AngularVelocityAdd(RecRoomObjectPort Target, Vector3Port AngularVelocity, FloatPort SpeedMultiplier, FloatPort MaxAngularSpeed)
        {
            Node node = new Node()
            {Name = "Angular Velocity Add", Type = "956ccd66-4406-42a3-b08c-78d3efdd5fec", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, AngularVelocity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, SpeedMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, MaxAngularSpeed, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void AngularVelocityAddDeprecated(RecRoomObjectPort Target, Vector3Port Rotation, FloatPort VelocityMultiplier, FloatPort MaxAngularVelocityApplied)
        {
            Node node = new Node()
            {Name = "Angular Velocity Add (Deprecated)", Type = "87f6886f-fa2b-4961-b0ed-c8014aadc56b", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, VelocityMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, MaxAngularVelocityApplied, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AngularVelocityAddDeprecated(RecRoomObjectPort Target, QuaternionPort Rotation, FloatPort VelocityMultiplier, FloatPort MaxAngularVelocityApplied)
        {
            Node node = new Node()
            {Name = "Angular Velocity Add (Deprecated)", Type = "87f6886f-fa2b-4961-b0ed-c8014aadc56b", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, VelocityMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, MaxAngularVelocityApplied, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort AngularVelocitySet(RecRoomObjectPort Target, Vector3Port AngularVelocity, FloatPort SpeedMultiplier)
        {
            Node node = new Node()
            {Name = "Angular Velocity Set", Type = "85dbc1d1-759a-4d08-b129-bf9372188348", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, AngularVelocity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, SpeedMultiplier, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void AngularVelocitySetDeprecated(RecRoomObjectPort Target, Vector3Port Rotation, FloatPort VelocityMultiplier)
        {
            Node node = new Node()
            {Name = "Angular Velocity Set (Deprecated)", Type = "98b24bc7-32d8-4386-9348-d44ad00d7702", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, VelocityMultiplier, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AngularVelocitySetDeprecated(RecRoomObjectPort Target, QuaternionPort Rotation, FloatPort VelocityMultiplier)
        {
            Node node = new Node()
            {Name = "Angular Velocity Set (Deprecated)", Type = "98b24bc7-32d8-4386-9348-d44ad00d7702", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, VelocityMultiplier, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort AnimationGetFrame(AnimationControllerPort Animator)
        {
            Node node = new Node()
            {Name = "Animation Get Frame", Type = "5460ad14-4d51-4925-bd27-1ced46f10cb4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AnimationGetIsPlaying(AnimationControllerPort Animator)
        {
            Node node = new Node()
            {Name = "Animation Get Is Playing", Type = "b45a0e10-189e-4211-b152-f04863d36e8c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AnimationGetSpeed(AnimationControllerPort Animator)
        {
            Node node = new Node()
            {Name = "Animation Get Speed", Type = "e73794bd-fd60-4284-90ca-f5169700fa23", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AnimationGetTimeStamp(AnimationControllerPort Animator)
        {
            Node node = new Node()
            {Name = "Animation Get Time Stamp", Type = "19a1867b-8322-45b5-9971-c91b246663f3", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AnimationPause(AnimationControllerPort Animator)
        {
            Node node = new Node()
            {Name = "Animation Pause", Type = "16144990-d5b0-4143-83f2-0df3cd30b3f2", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationPlay(AnimationControllerPort Animator)
        {
            Node node = new Node()
            {Name = "Animation Play", Type = "c2dc73dd-5317-45bf-892a-46864b468960", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationSetFrame(AnimationControllerPort Animator, IntPort FrameNumber)
        {
            Node node = new Node()
            {Name = "Animation Set Frame", Type = "c7ae96f2-1792-40ab-a367-6cc159f27080", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, FrameNumber, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationSetSpeed(AnimationControllerPort Animator, FloatPort Speed)
        {
            Node node = new Node()
            {Name = "Animation Set Speed", Type = "ca4d8318-ff8a-4c05-8628-2573d3c0ab4b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationSetTimeStamp(AnimationControllerPort Animator, FloatPort TimeStamp)
        {
            Node node = new Node()
            {Name = "Animation Set Time Stamp", Type = "2cee5b7c-d9d1-455d-913c-10441527c798", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, TimeStamp, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationStop(AnimationControllerPort Animator)
        {
            Node node = new Node()
            {Name = "Animation Stop", Type = "454c3ee3-5030-4a63-8ae9-1a0c61568f8c", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Animator, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Asin(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Asin", Type = "aaa4e58f-16df-426a-b7a7-a654eab97037", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Atan(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Atan", Type = "84646ed2-015e-4a8b-9d37-5115cb9ebadc", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Atan2(FloatPort Y, FloatPort X)
        {
            Node node = new Node()
            {Name = "Atan2", Type = "02d62908-550d-4f8b-8bc7-0960fb1b547f", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Y, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, X, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioGetLength(AudioPort Audio)
        {
            Node node = new Node()
            {Name = "Audio Get Length", Type = "be5262f0-1f67-4be7-aa8c-967c30bd5487", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Audio, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static AudioPort AudioPlayerGetAudio(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Audio", Type = "0f4433b6-425d-4172-968a-2c867bc0fef5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetMaxRolloffDistance(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Max Rolloff Distance", Type = "2db28fb7-0edb-4f09-8d74-ed5614dfaf11", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AudioPlayerGetPlaying(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Playing", Type = "00443d01-632e-4f75-ac6f-23b3e224e791", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetSpeed(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Speed", Type = "931ebb4f-3424-4aa3-bee3-5e039ba210e4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetTimeStamp(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Time Stamp", Type = "61e8293d-5d5a-4dbc-9505-0a13faf8b4cc", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetVolume(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Volume", Type = "1bbabac2-f316-4e07-9eb6-fd65848a5b90", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AudioPlayerPause(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Pause", Type = "e6391f35-dd8b-4e99-a0f9-7dc44b6c1893", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerPlay(AudioPlayerPort Target, AudioPort Audio)
        {
            Node node = new Node()
            {Name = "Audio Player Play", Type = "38f16370-7224-40d0-a551-665bb9fb6f8b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Audio, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetMaxRolloffDistance(AudioPlayerPort Target, FloatPort MaxRolloffDistance)
        {
            Node node = new Node()
            {Name = "Audio Player Set Max Rolloff Distance", Type = "c8b0ee69-7b27-4805-b809-438b1c59f472", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxRolloffDistance, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetSpeed(AudioPlayerPort Target, FloatPort Speed)
        {
            Node node = new Node()
            {Name = "Audio Player Set Speed", Type = "a59e93b4-f949-47b4-af73-fb6e110392fa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetTimeStamp(AudioPlayerPort Target, FloatPort TimeStamp)
        {
            Node node = new Node()
            {Name = "Audio Player Set Time Stamp", Type = "d30959ca-fa17-498b-88da-a83a46c34b97", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, TimeStamp, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetVolume(AudioPlayerPort Target, FloatPort Volume)
        {
            Node node = new Node()
            {Name = "Audio Player Set Volume", Type = "cdedf5fe-9d4f-4811-9883-160b04695657", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Volume, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerStop(AudioPlayerPort Target)
        {
            Node node = new Node()
            {Name = "Audio Player Stop", Type = "f6c546cc-becd-44cc-999b-bf2031b5f737", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort AwardConsumable(ConsumablePort Consumable, PlayerPort Player, IntPort Quantity, AlternativeExec<BoolPort> OnAwardConsumableComplete)
        {
            Node node = new Node()
            {Name = "Award Consumable", Type = "9ceb3e5a-2030-4034-98a4-dc2809828b63", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Consumable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Quantity, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnAwardConsumableComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) AwardCurrency(PlayerPort Player, IntPort Amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnAwardCurrencyComplete)
        {
            Node node = new Node()
            {Name = "Award Currency", Type = "03461631-734f-491b-ab86-6bdf66947556", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Amount, new Port{Node = node, Index = 2});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnAwardCurrencyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) AwardCurrencyNew(RoomCurrencyPort Currency, PlayerPort Player, IntPort Amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnAwardCurrencyComplete)
        {
            Node node = new Node()
            {Name = "Award Currency (New)", Type = "9ad9cfa5-da73-4bc6-b53e-e2fdc265998f", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Currency, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Amount, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnAwardCurrencyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort AwardRoomKey(RoomKeyPort RoomKey, PlayerPort Player, AlternativeExec<BoolPort> OnAwardRoomKeyComplete)
        {
            Node node = new Node()
            {Name = "Award Room Key", Type = "7e40f770-c9a4-4233-8845-cac6ec99ae67", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, RoomKey, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnAwardRoomKeyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BackgroundObjectsPort BackgroundObjectsConstant()
        {
            Node node = new Node()
            {Name = "Background Objects Constant", Type = "c6e9ffef-b505-41d3-bb2d-ff86838398c6", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new BackgroundObjectsPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort BeaconGetColor(BeaconPort Target)
        {
            Node node = new Node()
            {Name = "Beacon Get Color", Type = "5f7cd28c-bafc-409d-8872-f21ccec5f022", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort BeaconGetEnabled(BeaconPort Target)
        {
            Node node = new Node()
            {Name = "Beacon Get Enabled", Type = "5646ab78-1388-44de-84a7-8c50f28cc88e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort BeaconGetHeight(BeaconPort Target)
        {
            Node node = new Node()
            {Name = "Beacon Get Height", Type = "dbadcaaa-d673-4e35-bb29-c9c2a5c3d93e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void BeaconSetColor(BeaconPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Beacon Set Color", Type = "6e01d9d9-fd3d-4248-b954-df283ceb1316", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void BeaconSetEnabled(BeaconPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Beacon Set Enabled", Type = "d8a84892-15a7-4069-800d-f77ea4ed6bea", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void BeaconSetHeight(BeaconPort Target, FloatPort Height)
        {
            Node node = new Node()
            {Name = "Beacon Set Height", Type = "a93f6c3f-232a-470a-9f01-f1b591200ad7", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Height, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort BitAnd(IntPort Port0, IntPort Port1)
        {
            Node node = new Node()
            {Name = "Bit And", Type = "28a95bc3-ab08-48ae-b0c0-16b41168bf47", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitLeadingZeros(IntPort Value)
        {
            Node node = new Node()
            {Name = "Bit Leading Zeros", Type = "d6e62624-06b0-416e-8e3c-ca058efd3c46", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitNand(IntPort Port0, IntPort Port1)
        {
            Node node = new Node()
            {Name = "Bit Nand", Type = "05305e33-a809-4751-b928-2c8a5bbc6dc9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitNot(IntPort Port0)
        {
            Node node = new Node()
            {Name = "Bit Not", Type = "ec74ea41-24e5-491c-8919-a502638583f9", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitOr(IntPort Port0, IntPort Port1)
        {
            Node node = new Node()
            {Name = "Bit Or", Type = "2c24bc11-9543-4738-8c6c-0c5e3fadd944", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitPopCount(IntPort Value)
        {
            Node node = new Node()
            {Name = "Bit Pop Count", Type = "6982e235-5814-4c5a-8bc8-fdbcc9a73eb8", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitRotateLeft(IntPort Value, IntPort Shift)
        {
            Node node = new Node()
            {Name = "Bit Rotate Left", Type = "bd013fe7-3799-46b5-b1f3-66a3f5add5ed", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitRotateRight(IntPort Value, IntPort Shift)
        {
            Node node = new Node()
            {Name = "Bit Rotate Right", Type = "b5f36fdf-0a2e-489a-bbdf-f17c50974cc1", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitShiftLeft(IntPort Value, IntPort Shift)
        {
            Node node = new Node()
            {Name = "Bit Shift Left", Type = "0a7b4058-b1da-442f-8341-81df66979663", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitShiftRight(IntPort Value, IntPort Shift)
        {
            Node node = new Node()
            {Name = "Bit Shift Right", Type = "4024b483-ab3d-4fa0-b399-b3350b800081", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitTrailingZeros(IntPort Value)
        {
            Node node = new Node()
            {Name = "Bit Trailing Zeros", Type = "773d361e-3761-497b-9dec-b5e5313a5a2c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitXor(IntPort Port0, IntPort Port1)
        {
            Node node = new Node()
            {Name = "Bit Xor", Type = "a3899394-1ed9-4d41-a836-22fffaf4e90d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort BoolVariable(BoolPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "bool Variable", Type = "80955588-7f7a-4f7c-b46f-6d1e9057fba0", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static (T0 Item1, T1 Item2) BreakTuple<T0, T1>(RRTuplePort<T0, T1> Tuple)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Break Tuple", Type = "9478334a-451d-4802-bab1-4b05f00d45e4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Tuple, new Port{Node = node, Index = 0});
            var output_ports = (new T0{Port = new Port{Node = node, Index = 0}}, new T1{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort ButtonGetIsPressed(ButtonPort Target)
        {
            Node node = new Node()
            {Name = "Button Get Is Pressed", Type = "fe32ba92-9018-4575-92e2-3b0d82c9419b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ButtonGetText(ButtonPort Target)
        {
            Node node = new Node()
            {Name = "Button Get Text", Type = "70e7663d-a5fd-435d-8995-942b4babc262", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ButtonSetText(ButtonPort Target, StringPort Text)
        {
            Node node = new Node()
            {Name = "Button Set Text", Type = "21bbaa09-6bcf-435c-86da-e853a78bc27b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Text, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Ceil(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Ceil", Type = "f4cbc476-bc98-4cbf-bf47-de4baedddf79", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort CeilToInt(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Ceil to Int", Type = "38b502dc-dd35-4083-a2b0-8a8e5f69a958", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void CircuitBoard()
        {
            Node node = new Node()
            {Name = "Circuit Board", Type = "14ebde7a-76c0-47df-b0dd-01b1daa50821", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static FloatPort Clamp(FloatPort Value, FloatPort Min, FloatPort Max)
        {
            Node node = new Node()
            {Name = "Clamp", Type = "f95735f1-1db8-4bf4-8198-03b2595fa741", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Max, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort Clamp(IntPort Value, IntPort Min, IntPort Max)
        {
            Node node = new Node()
            {Name = "Clamp", Type = "f95735f1-1db8-4bf4-8198-03b2595fa741", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Max, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ClearPlayerVignette(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Clear Player Vignette", Type = "161bdcc8-4156-4c8f-9792-2a1285b97e68", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ClearPlayerWorldUI(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Clear Player World UI", Type = "c25487e3-657a-4ee8-b766-c2a1b10ec481", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ClearScreen(TextScreenPort Target)
        {
            Node node = new Node()
            {Name = "Clear Screen", Type = "142438cd-1bd2-4df2-b2fa-c93aaf99f771", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort CollisionDataGetDistance(CollisionDataPort Target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Distance", Type = "c3fc963c-6d73-4d88-9c9b-95e9faae219f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CollisionDataGetNormal(CollisionDataPort Target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Normal", Type = "ced470f8-dd9d-4e67-a654-7c7e1a3e7819", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecRoomObjectPort CollisionDataGetObject(CollisionDataPort Target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Object", Type = "8c8931da-1a8e-4164-a3a5-0f68db8cafb5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort CollisionDataGetPlayer(CollisionDataPort Target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Player", Type = "2729e8db-62d1-4f9e-b076-74f27cd43332", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CollisionDataGetPosition(CollisionDataPort Target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Position", Type = "5910618b-f862-49ce-9779-46130e47f985", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort CollisionDetectionVolumeGetEnabled(CollisionDetectionVolumePort Target)
        {
            Node node = new Node()
            {Name = "Collision Detection Volume Get Enabled", Type = "9b5e9c57-babc-4e7a-a728-97bef7a11cfc", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void CollisionDetectionVolumeSetEnabled(CollisionDetectionVolumePort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Collision Detection Volume Set Enabled", Type = "711cadd1-24b0-4969-9fba-f65cbaeab3c5", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ColorPort ColorConstant()
        {
            Node node = new Node()
            {Name = "Color Constant", Type = "87a8e178-b15c-4c38-9da0-95ba74f9f4ec", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Hue, FloatPort Saturation, FloatPort Value) ColorToHSV(ColorPort Color)
        {
            Node node = new Node()
            {Name = "Color To HSV", Type = "d697171e-56ac-41b7-aa1e-dabc4538c029", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static IntPort ColorToInt(ColorPort Color)
        {
            Node node = new Node()
            {Name = "Color To Int", Type = "8e412141-635d-435c-a900-f40d8a261906", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Red, FloatPort Green, FloatPort Blue) ColorToRGB(ColorPort Color)
        {
            Node node = new Node()
            {Name = "Color To RGB", Type = "52565e5d-73d1-4f29-bca7-0c8ae9afcc57", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static ColorPort ColorVariable(ColorPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Color Variable", Type = "3d2fd0b5-eeac-45cc-a622-1701710f0792", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static Vector3Port CombatantGetGroundPosition(AIPort Combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Ground Position", Type = "c0ee02f4-bbab-40ea-88a0-7441d7e7094c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Combatant, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CombatantGetGroundPosition(CombatantPort Combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Ground Position", Type = "c0ee02f4-bbab-40ea-88a0-7441d7e7094c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Combatant, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CombatantGetGroundPosition(PlayerPort Combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Ground Position", Type = "c0ee02f4-bbab-40ea-88a0-7441d7e7094c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Combatant, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealth(AIPort Object)
        {
            Node node = new Node()
            {Name = "Combatant Get Health", Type = "3967a8ad-4237-4ae7-8cbf-850d8e24fe30", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealth(CombatantPort Object)
        {
            Node node = new Node()
            {Name = "Combatant Get Health", Type = "3967a8ad-4237-4ae7-8cbf-850d8e24fe30", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealth(PlayerPort Object)
        {
            Node node = new Node()
            {Name = "Combatant Get Health", Type = "3967a8ad-4237-4ae7-8cbf-850d8e24fe30", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static BoolPort CombatantGetIsAlive(AIPort Object)
        {
            Node node = new Node()
            {Name = "Combatant Get Is Alive", Type = "2a12c389-c3c6-4484-8c63-21cdaf0fac6c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort CombatantGetIsAlive(CombatantPort Object)
        {
            Node node = new Node()
            {Name = "Combatant Get Is Alive", Type = "2a12c389-c3c6-4484-8c63-21cdaf0fac6c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort CombatantGetIsAlive(PlayerPort Object)
        {
            Node node = new Node()
            {Name = "Combatant Get Is Alive", Type = "2a12c389-c3c6-4484-8c63-21cdaf0fac6c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocity(AIPort Combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Velocity", Type = "b4eadbfa-cdbe-42e6-9481-5197de58e272", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Combatant, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocity(CombatantPort Combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Velocity", Type = "b4eadbfa-cdbe-42e6-9481-5197de58e272", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Combatant, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocity(PlayerPort Combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Velocity", Type = "b4eadbfa-cdbe-42e6-9481-5197de58e272", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Combatant, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static void CombatantReceiveDamage(AIPort Target, IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(AIPort Target, IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(AIPort Target, IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(CombatantPort Target, IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(CombatantPort Target, IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(CombatantPort Target, IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(PlayerPort Target, IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(PlayerPort Target, IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamage(PlayerPort Target, IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IgnoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, DamageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetHealth(AIPort Target, IntPort Health)
        {
            Node node = new Node()
            {Name = "Combatant Set Health", Type = "3dc4807f-2acd-446d-928f-5d301d0795d6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Health, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetHealth(CombatantPort Target, IntPort Health)
        {
            Node node = new Node()
            {Name = "Combatant Set Health", Type = "3dc4807f-2acd-446d-928f-5d301d0795d6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Health, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetHealth(PlayerPort Target, IntPort Health)
        {
            Node node = new Node()
            {Name = "Combatant Set Health", Type = "3dc4807f-2acd-446d-928f-5d301d0795d6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Health, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetMaxHealth(AIPort Target, IntPort MaxHealth)
        {
            Node node = new Node()
            {Name = "Combatant Set Max Health", Type = "82f71bcc-5e83-4825-8306-6a2bb2a296dd", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxHealth, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetMaxHealth(CombatantPort Target, IntPort MaxHealth)
        {
            Node node = new Node()
            {Name = "Combatant Set Max Health", Type = "82f71bcc-5e83-4825-8306-6a2bb2a296dd", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxHealth, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetMaxHealth(PlayerPort Target, IntPort MaxHealth)
        {
            Node node = new Node()
            {Name = "Combatant Set Max Health", Type = "82f71bcc-5e83-4825-8306-6a2bb2a296dd", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxHealth, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort IsPlayer, PlayerPort Player, AIPort AI) CombatantSplit(CombatantPort Combatant)
        {
            Node node = new Node()
            {Name = "Combatant Split", Type = "81b08e44-0a1e-40da-b8a1-79f416691dcf", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Combatant, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}}, new AIPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static CombatantPort CombatantVariable(CombatantPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Combatant Variable", Type = "cfd8e246-8682-4707-a0ae-da55bacfbf72", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void Comment()
        {
            Node node = new Node()
            {Name = "Comment", Type = "83623f53-86b2-477d-bb2f-fe68f68ba617", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static void ConsumableActivate(ConsumablePort Consumable)
        {
            Node node = new Node()
            {Name = "Consumable Activate", Type = "d7ea08ab-aee6-43d0-99e1-54478ac3db7f", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Consumable, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ConsumablePort ConsumableConstant()
        {
            Node node = new Node()
            {Name = "Consumable Constant", Type = "3dc63876-39a9-4828-9967-67821e620cb1", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new ConsumablePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ConsumableDeactivate(ConsumablePort Consumable)
        {
            Node node = new Node()
            {Name = "Consumable Deactivate", Type = "6809978a-e1fc-403a-a41a-d4e94f22281f", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Consumable, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort ControlPanel()
        {
            Node node = new Node()
            {Name = "Control Panel", Type = "0e7f87db-1745-482b-993b-68211255fbbd", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Cos(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Cos", Type = "e8659a59-9e11-4403-8bbc-f4a3961cbf21", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void CostumeEquip(CostumePort Target, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Costume Equip", Type = "1f57e165-dee2-470d-9ab2-9c836aeccccf", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static PlayerPort CostumeGetWearer(CostumePort Target)
        {
            Node node = new Node()
            {Name = "Costume Get Wearer", Type = "f28d1a5e-a08c-471b-89e6-5ee6372d9897", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort CostumeUnequip(CostumePort Target)
        {
            Node node = new Node()
            {Name = "Costume Unequip", Type = "d5070b89-da23-4e4b-848c-07bb22c0420e", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void DataTable(AnyPort Port0)
        {
            Node node = new Node()
            {Name = "Data Table", Type = "cf314640-805c-4ebc-958c-d10ed65ca9b8", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            return;
        }

        public static ListPort<IntPort> DataTableGetAllRowsContaining()
        {
            Node node = new Node()
            {Name = "Data Table Get All Rows Containing", Type = "0a04aa3b-22bd-44a8-8613-9c02db855e88", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new ListPort<IntPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort DataTableGetColumnCount()
        {
            Node node = new Node()
            {Name = "Data Table Get Column Count", Type = "bf05749e-c89e-4aa2-97f8-31c105f45b49", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort DataTableGetFirstRowContaining()
        {
            Node node = new Node()
            {Name = "Data Table Get First Row Containing", Type = "699f2839-0742-4b3d-80ca-4394fb60e7e2", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort DataTableGetRowCount()
        {
            Node node = new Node()
            {Name = "Data Table Get Row Count", Type = "e32052ce-0f54-4875-aa11-39e8c2761deb", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static void DataTableReadCell(IntPort Row, DataTableColumnData config)
        {
            Node node = new Node()
            {Name = "Data Table Read Cell", Type = "4b6cff3d-0ead-43cd-bfa7-a22c87b31b0a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Row, new Port{Node = node, Index = 0});
            node.DataTableColumnData = config;
            return;
        }

        public static void Delay(FloatPort Delay, AlternativeExec AfterDelay, AlternativeExec Cancel)
        {
            Node node = new Node()
            {Name = "Delay", Type = "cefee2a5-d4a8-4dff-8c4e-bad684ca8d34", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Delay, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            AfterDelay();
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            Cancel();
            ExecFlow.current = mainFlow;
            return;
        }

        public static DestinationRoomPort DestinationRoomConstant()
        {
            Node node = new Node()
            {Name = "Destination Room Constant", Type = "330f3621-0d37-4cd7-8b92-270c7df43fcb", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new DestinationRoomPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static DestinationRoomPort DestinationRoomVariable(DestinationRoomPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Destination Room Variable", Type = "31eab00d-a6f7-4505-9f84-02d3e1eedd86", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new DestinationRoomPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static (StringPort BodyText, BoolPort IsInteractive) DialogueUIGetDialogueText(DialogueUIPort Target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Dialogue Text", Type = "ecd48cf6-f25a-4650-a120-4bbf05fbfa1c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort DialogueUIGetIsEnabled(DialogueUIPort Target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Is Enabled", Type = "24e650ed-b099-44ba-944a-d33ea34fff8b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort DialogueUIGetTitleIsEnabled(DialogueUIPort Target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Title Is Enabled", Type = "44661525-612e-4032-8278-fcb15a72aee0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort DialogueUIGetTitleText(DialogueUIPort Target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Title Text", Type = "17a13c0d-f5c0-4806-b6ee-1af03eb81bdb", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void DialogueUISetButtonState(DialogueUIPort Target, BoolPort Button1Enabled, StringPort Button1Text, BoolPort Button2Enabled, StringPort Button2Text, BoolPort Button3Enabled, StringPort Button3Text, BoolPort Button4Enabled, StringPort Button4Text)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Button State", Type = "f4772dae-d4e3-489c-8943-8fe88160ab5c", InputCount = 10};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Button1Enabled, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Button1Text, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Button2Enabled, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, Button2Text, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, Button3Enabled, new Port{Node = node, Index = 6});
            node.ConnectInputPort(Context.current, Button3Text, new Port{Node = node, Index = 7});
            node.ConnectInputPort(Context.current, Button4Enabled, new Port{Node = node, Index = 8});
            node.ConnectInputPort(Context.current, Button4Text, new Port{Node = node, Index = 9});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetDialogueText(DialogueUIPort Target, StringPort BodyText, BoolPort IsInteractive)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Dialogue Text", Type = "bc6602e4-e88b-4db4-9655-0a6baf50997e", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, BodyText, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IsInteractive, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetIsEnabled(DialogueUIPort Target, BoolPort IsEnabled)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Is Enabled", Type = "a348af16-bd74-4da6-a3e1-1bf1e2456eba", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, IsEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetTitleIsEnabled(DialogueUIPort Target, BoolPort IsEnabled)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Title Is Enabled", Type = "54a8ee30-21fa-4f74-8f54-5c8936a2e7bb", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, IsEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetTitleText(DialogueUIPort Target, StringPort TitleText)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Title Text", Type = "45566130-ee6e-4eca-8f05-7e264001afc1", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, TitleText, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static PlayerPort DiceGetPlayerRolled(DiePort Target)
        {
            Node node = new Node()
            {Name = "Dice Get Player Rolled", Type = "c1fdc4fa-fcb4-4ea4-b505-7b1d15fb8117", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort DiceGetResult(DiePort Target)
        {
            Node node = new Node()
            {Name = "Dice Get Result", Type = "c80e2979-c672-4e7a-81fb-0ed1964e3ea6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort DiceGetRollFinished(DiePort Target)
        {
            Node node = new Node()
            {Name = "Dice Get Roll finished", Type = "b8735ad9-cd89-4d81-ab9b-be3eb50e3b5a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void DisplayPlayerWorldUI(PlayerWorldUIPort Target, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Display Player World UI", Type = "dfbf7060-c08a-4f20-818c-02afe1c36b38", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Distance(AIPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port A, AIPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port A, CombatantPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port A, RecRoomObjectPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port A, PlayerPort B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port A, Vector3Port B)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Divide(IntPort Value)
        {
            Node node = new Node()
            {Name = "Divide", Type = "f2eafd78-5f23-44c9-a271-8ff2f0762e71", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Divide(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Divide", Type = "f2eafd78-5f23-44c9-a271-8ff2f0762e71", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Divide(Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Divide", Type = "f2eafd78-5f23-44c9-a271-8ff2f0762e71", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static DestinationRoomPort DoorGetDestination(RoomDoorPort Target)
        {
            Node node = new Node()
            {Name = "Door Get Destination", Type = "5f0eb749-1c4e-46fb-b2d1-4faaf69446bb", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new DestinationRoomPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort DoorGetLocked(RoomDoorPort Target)
        {
            Node node = new Node()
            {Name = "Door Get Locked", Type = "f2918d8a-444c-429d-ab79-e2d445695a57", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void DoorSetDestination(RoomDoorPort Target, DestinationRoomPort Room)
        {
            Node node = new Node()
            {Name = "Door Set Destination", Type = "5b9dc865-0fac-4d3a-9edc-68184ee189a2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Room, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DoorSetLocked(RoomDoorPort Target, BoolPort Locked)
        {
            Node node = new Node()
            {Name = "Door Set Locked", Type = "7ca4abb2-d705-4c17-b713-7525122ef286", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Locked, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort EmitterGetLooping(EmitterPort Target)
        {
            Node node = new Node()
            {Name = "Emitter Get Looping", Type = "f8c91da0-bb4f-4958-9016-546a387f45dd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort EmitterGetPlaying(EmitterPort Target)
        {
            Node node = new Node()
            {Name = "Emitter Get Playing", Type = "9fbee635-c6a4-4a02-a67b-295e075db7c9", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort EmitterGetSize(EmitterPort Target)
        {
            Node node = new Node()
            {Name = "Emitter Get Size", Type = "08c3c01c-2c40-4b92-a913-e5a8cbbbe352", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort EmitterGetSpeed(EmitterPort Target)
        {
            Node node = new Node()
            {Name = "Emitter Get Speed", Type = "df10f3b8-e5b8-49ad-9112-22cc0e3bdb9f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void EmitterSetColor(EmitterPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Emitter Set Color", Type = "4263768a-035b-4d8b-b17c-1a7bb0b9b96d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetColorId(EmitterPort Target, IntPort Value)
        {
            Node node = new Node()
            {Name = "Emitter Set Color Id", Type = "15e42063-cbae-40f9-a9e4-8226e83217ec", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetLooping(EmitterPort Target, BoolPort Value)
        {
            Node node = new Node()
            {Name = "Emitter Set Looping", Type = "36881bd0-7da0-44a7-b6ef-8cd3770fed78", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetSize(EmitterPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Emitter Set Size", Type = "1fdf4bab-c868-4ffb-8bfc-b2e360450495", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetSpeed(EmitterPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Emitter Set Speed", Type = "12446960-d971-475f-b64e-b5c7bb422eca", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterStart(EmitterPort Target)
        {
            Node node = new Node()
            {Name = "Emitter Start", Type = "56ebaa0b-256a-40ed-a066-f5663dfa2b59", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterStop(EmitterPort Target)
        {
            Node node = new Node()
            {Name = "Emitter Stop", Type = "23b278c4-5d3d-439d-afa3-ff30c949df97", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static BoolPort Equals<T>(T Value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Equals", Type = "e1f1b65e-8d82-47af-8637-ae2d0afa431f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort EqualsDeprecated<T>(T A, T B)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Equals", Type = "3663225d-e18d-40e6-a234-ef10378528be", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static EquipmentSlotPort EquipmentSlot()
        {
            Node node = new Node()
            {Name = "Equipment Slot", Type = "1abf31dd-fa6e-43bb-9eb4-94a06e62f139", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new EquipmentSlotPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort EquipObjectToDominantHand(PlayerPort Player, RecRoomObjectPort ObjectToEquip, BoolPort ForceEquip, BoolPort Steal)
        {
            Node node = new Node()
            {Name = "Equip Object to Dominant Hand", Type = "c840f770-80aa-4e96-8677-963a2ca3cff1", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ObjectToEquip, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, ForceEquip, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Steal, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort EquipObjectToOffHand(PlayerPort Player, RecRoomObjectPort ObjectToEquip, BoolPort ForceEquip, BoolPort Steal)
        {
            Node node = new Node()
            {Name = "Equip Object to Off Hand", Type = "52da50b9-2d34-4128-a1bd-3e056f236e2c", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ObjectToEquip, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, ForceEquip, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Steal, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void EventDefinition(EventDefinitionData config)
        {
            Node node = new Node()
            {Name = "Event Definition", Type = "7d72a1fa-a434-4437-a73a-51f306a3f55f", InputCount = 0};
            Context.current.Nodes.Add(node);
            node.EventDefinitionData = config;
            return;
        }

        public static void EventReceiver(EventReceiverData config)
        {
            Node node = new Node()
            {Name = "Event Receiver", Type = "8b533ccb-643a-491d-982c-94417ce99954", InputCount = 0};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, null, new Port{Node = node});
            node.EventReceiverData = config;
            return;
        }

        public static void EventSender(EventSenderData config)
        {
            Node node = new Node()
            {Name = "Event Sender", Type = "96a8fe50-bc37-458b-bac9-582d45314779", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.EventSenderData = config;
            return;
        }

        public static void ExecutionIntegerSwitch(IntPort Match)
        {
            Node node = new Node()
            {Name = "Execution Integer Switch", Type = "0387e4c7-b917-4d19-937f-5da37b9f41cc", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Match, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExecutionStringSwitch(StringPort Match)
        {
            Node node = new Node()
            {Name = "Execution String Switch", Type = "80c7d803-df40-45a5-ac7b-bfccb0b511c7", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Match, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterExplode(ExplosionEmitterPort Target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Explode", Type = "49774675-e750-441f-9e92-8455232f1703", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort ExplosionEmitterGetDamage(ExplosionEmitterPort Target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Damage", Type = "87d94359-da69-49ed-8b61-fbf78d79fa48", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort ExplosionEmitterGetExplosionColor(ExplosionEmitterPort Target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Explosion Color", Type = "6039d63b-f484-4436-bb7c-ea58529ed4ec", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ExplosionEmitterGetExplosionRadius(ExplosionEmitterPort Target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Explosion Radius", Type = "eff7cfca-dcee-4ea1-887f-e4c60f3c8269", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort ExplosionEmitterGetFiringPlayer(ExplosionEmitterPort Target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Firing Player", Type = "36cd4562-2c1f-43e3-ba90-56daa0cb7339", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ExplosionEmitterSetDamage(ExplosionEmitterPort Target, IntPort Damage)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Damage", Type = "748f210d-f9e2-4dca-a29a-8eacf99daff7", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterSetExplosionColor(ExplosionEmitterPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Explosion Color", Type = "a3211c4f-9924-4a9a-afea-ab48f37bbc67", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterSetExplosionRadius(ExplosionEmitterPort Target, FloatPort Radius)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Explosion Radius", Type = "672e473f-7099-4f76-aead-8b3df7c2fcd2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Radius, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterSetFiringPlayer(ExplosionEmitterPort Target, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Firing Player", Type = "d39b968d-bdab-4548-aaa7-745e3155789e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort FloatVariable(FloatPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "float Variable", Type = "04a31ca5-91d2-4a69-bf3d-484d18411cc0", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort Floor(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Floor", Type = "c90d9339-cdce-4d22-a885-f142fd5567ab", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort FloorToInt(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Floor to Int", Type = "bc451cab-2292-4e60-832d-31060eb82bd0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FogPort FogConstant()
        {
            Node node = new Node()
            {Name = "Fog Constant", Type = "3026a5c6-232f-4961-b18a-5ad179e6b24d", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new FogPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort For(IntPort From, IntPort To, AlternativeExec<IntPort> Done)
        {
            Node node = new Node()
            {Name = "For", Type = "8f945c22-988b-45d2-b7f2-409ba304fef4", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, From, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, To, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            Done(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static T ForEach<T>(ListPort<T> Items, AlternativeExec<T> Done)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "For Each", Type = "744e5311-6cc7-4130-962e-fe050a475d43", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Items, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            Done(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static T FromRecRoomObject<T>(RecRoomObjectPort Target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "From Rec Room Object", Type = "7ff685a6-f59c-4c6c-b559-f343d81ea1d4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static HUDElementPort GameHUDElementConstant()
        {
            Node node = new Node()
            {Name = "Game HUD Element Constant", Type = "4a3c3d38-f1a4-493b-977f-5444ab2d404b", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new HUDElementPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GameHUDElementSetAllValues(HUDElementPort Target)
        {
            Node node = new Node()
            {Name = "Game HUD Element Set All Values", Type = "31295d8e-f416-4c44-b0bd-2eda32200365", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<PlayerPort> GetAllPlayers()
        {
            Node node = new Node()
            {Name = "Get All Players", Type = "3f4346b1-bc6f-4aca-9650-d43cbd4acc5b", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> GetAllPlayersDeprecated()
        {
            Node node = new Node()
            {Name = "Get All Players (Deprecated)", Type = "09b0bf5b-95df-474b-b81a-4e8e2c78ed0a", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> GetAllPlayersWithRole(StringPort RoleName)
        {
            Node node = new Node()
            {Name = "Get All Players With Role", Type = "1c0a6bd4-bcac-40a9-8bae-fceff7ff7cff", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, RoleName, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetAngularVelocity(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Angular Velocity", Type = "0922120c-c5b8-4109-8001-61b3131072a4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetAnyPlayerWithRole(StringPort Role)
        {
            Node node = new Node()
            {Name = "Get Any Player with Role", Type = "a924cac0-0245-4846-862d-df4092c5e1c2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetAuthority()
        {
            Node node = new Node()
            {Name = "Get Authority", Type = "eaf712f8-3257-4415-9f88-ae94e308396e", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort AudienceCount, IntPort BroadcasterCount, BoolPort IsBroadcastActive) GetBroadcastingAttendance()
        {
            Node node = new Node()
            {Name = "Get Broadcasting Attendance", Type = "78f5a9f2-4e3d-4534-aada-4af3a551a953", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new BoolPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(RecRoomObjectPort Origin, ListPort<RecRoomObjectPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(RecRoomObjectPort Origin, ListPort<PlayerPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(RecRoomObjectPort Origin, ListPort<Vector3Port> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(PlayerPort Origin, ListPort<RecRoomObjectPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(PlayerPort Origin, ListPort<PlayerPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(PlayerPort Origin, ListPort<Vector3Port> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(Vector3Port Origin, ListPort<RecRoomObjectPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(Vector3Port Origin, ListPort<PlayerPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(Vector3Port Origin, ListPort<Vector3Port> Targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) GetCurrencyBalance(PlayerPort Player, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnGetBalanceComplete)
        {
            Node node = new Node()
            {Name = "Get Currency Balance", Type = "a4b0c860-e7f0-4abf-ad7c-9be1805c3d01", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnGetBalanceComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) GetCurrencyBalanceNew(RoomCurrencyPort Currency, PlayerPort Player, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnGetBalanceComplete)
        {
            Node node = new Node()
            {Name = "Get Currency Balance (New)", Type = "01659b8a-db44-4b5e-9a58-c366dcfff666", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Currency, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnGetBalanceComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(RecRoomObjectPort Origin, ListPort<RecRoomObjectPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(RecRoomObjectPort Origin, ListPort<PlayerPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(RecRoomObjectPort Origin, ListPort<Vector3Port> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(PlayerPort Origin, ListPort<RecRoomObjectPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(PlayerPort Origin, ListPort<PlayerPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(PlayerPort Origin, ListPort<Vector3Port> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(Vector3Port Origin, ListPort<RecRoomObjectPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(Vector3Port Origin, ListPort<PlayerPort> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(Vector3Port Origin, ListPort<Vector3Port> Targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static StringPort GetFirstTag(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get First Tag", Type = "cb909206-8627-4c66-ac8d-47b1a046ef8b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetFirstTag(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get First Tag", Type = "cb909206-8627-4c66-ac8d-47b1a046ef8b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetFormattedTime(FloatPort UniversalSeconds, StringPort Format)
        {
            Node node = new Node()
            {Name = "Get Formatted Time", Type = "7dfed109-e641-47f3-8844-fd0753e4e764", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, UniversalSeconds, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Format, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetFormattedTime(IntPort UniversalSeconds, StringPort Format)
        {
            Node node = new Node()
            {Name = "Get Formatted Time", Type = "7dfed109-e641-47f3-8844-fd0753e4e764", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, UniversalSeconds, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Format, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVector(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector", Type = "4536e1df-1138-4a2c-9117-475bb3f38eae", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVector(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector", Type = "4536e1df-1138-4a2c-9117-475bb3f38eae", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVectorDeprecated(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector (Deprecated)", Type = "88f95338-d1a6-4fad-8424-d714d651f6ac", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVectorDeprecated(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector (Deprecated)", Type = "88f95338-d1a6-4fad-8424-d714d651f6ac", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetGameHUDElementColor(HUDConstantPort Target)
        {
            Node node = new Node()
            {Name = "Get Game HUD Element Color", Type = "119d2860-e05c-4140-ba5f-c24139b78652", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetGameHUDElementLabel(HUDConstantPort Target)
        {
            Node node = new Node()
            {Name = "Get Game HUD Element Label", Type = "98ef89de-7a1b-4043-8071-b5cda41030cd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetGameHUDElementMaxValue(HUDConstantPort Target)
        {
            Node node = new Node()
            {Name = "Get Game HUD Element Max Value", Type = "f59d4537-e8b4-4d19-b29f-d5203ce562af", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetGameHUDElementValue(HUDConstantPort Target)
        {
            Node node = new Node()
            {Name = "Get Game HUD Element Value", Type = "d9cbf25f-01c6-468f-8607-d1dd8317bb2f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetLoadingPlayers()
        {
            Node node = new Node()
            {Name = "Get Loading Players", Type = "2e02d617-5ada-4876-84ac-d1b6d6270fc4", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetLocalCameraForward()
        {
            Node node = new Node()
            {Name = "Get Local Camera Forward", Type = "70c830bb-223a-4a7c-b0ae-df240c6f1f33", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetLocalCameraPosition()
        {
            Node node = new Node()
            {Name = "Get Local Camera Position", Type = "c19eff8a-980c-444a-983f-bb4c53a94daf", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetLocalCameraRotation()
        {
            Node node = new Node()
            {Name = "Get Local Camera Rotation", Type = "912f0e1b-267d-4424-8002-3f82a2d835fe", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetLocalCameraUp()
        {
            Node node = new Node()
            {Name = "Get Local Camera Up", Type = "5d9da95f-a64f-4660-a11f-bf0855769659", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetLocalPlayer()
        {
            Node node = new Node()
            {Name = "Get Local Player", Type = "fdf733a8-bdd6-4800-b1d4-95b06b3d6f02", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetNewLine()
        {
            Node node = new Node()
            {Name = "Get New Line", Type = "975fde92-136c-4ce5-b749-bf149b817695", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> GetPartyOfPlayer(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Party Of Player", Type = "dcbd4d6a-8f42-48ef-ad66-e1f245228d84", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetPlayerAccountName(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Get Player Account Name", Type = "6141ff64-412b-452f-beb0-f338eb6abfb5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetPlayerByAccountName(StringPort Name)
        {
            Node node = new Node()
            {Name = "Get Player By Account Name", Type = "2ee5a268-9d44-4326-8a34-ad126a3218f2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Name, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetPlayerByDisplayName(StringPort Name)
        {
            Node node = new Node()
            {Name = "Get Player By Display Name", Type = "637e07e4-9b93-44b6-bba3-68966080d064", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Name, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetPlayerSeasonLeagueName(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Get Player Season League Name", Type = "288083ac-338d-410f-9395-fbd7c6e41207", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUIEnabled(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Enabled", Type = "36ad6c98-0fb8-43a0-bf8d-0784394d2d28", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetPlayerWorldUIPrimaryBarColor(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Color", Type = "72101b8c-e522-43ad-ad96-7332f7962c10", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUIPrimaryBarEnabled(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Enabled", Type = "125d57be-9afa-46b3-a1c4-0c967d044334", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUIPrimaryBarMaxValue(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Max Value", Type = "30eb2838-1409-4266-96ed-31b3e1e25408", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUIPrimaryBarValue(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Value", Type = "84f241f5-fa59-43a3-9b2d-029b831e9275", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetPlayerWorldUISecondaryBarColor(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Color", Type = "2e537d07-930e-44f6-8757-ff34c365fd06", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUISecondaryBarEnabled(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Enabled", Type = "eaddf07d-4beb-4841-990c-a6b674a66126", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUISecondaryBarMaxValue(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Max Value", Type = "b23bdd96-7676-4236-a5ab-ca0aae513916", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUISecondaryBarValue(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Value", Type = "cafb066f-d6f5-4a1a-a833-e1a0186c6d8e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetPlayerWorldUITextColor(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Text Color", Type = "a8cdbc23-b8de-431e-9428-10b7ccc07192", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUITextEnabled(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Text Enabled", Type = "cd1b799d-855a-4ade-b62f-043a0db60a44", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetPlayerWorldUITextValue(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Text Value", Type = "447bbb2e-11e4-408c-b4a9-b758e3e07ee7", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(AIPort Target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(CombatantPort Target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(AIPort Target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(CombatantPort Target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetRoomAuthority()
        {
            Node node = new Node()
            {Name = "Get Room Authority", Type = "d7557465-963e-4451-a55a-dea2050e9b74", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotation(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Rotation", Type = "d750b619-1dd8-4099-a1dd-627050cd5d41", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotation(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Rotation", Type = "d750b619-1dd8-4099-a1dd-627050cd5d41", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationDeprecated(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Rotation (Deprecated)", Type = "c453fa47-d0db-4c4a-a6a1-dac4ebad0aca", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationDeprecated(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Rotation (Deprecated)", Type = "c453fa47-d0db-4c4a-a6a1-dac4ebad0aca", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> GetTags(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Tags", Type = "e67cfcb7-03e8-4152-ba41-af8ca61d93fb", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> GetTags(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Tags", Type = "e67cfcb7-03e8-4152-ba41-af8ca61d93fb", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVector(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Up Vector", Type = "824f6801-17b6-4ada-9a97-4f36cef02e8b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVector(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Up Vector", Type = "824f6801-17b6-4ada-9a97-4f36cef02e8b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVectorDeprecated(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Up Vector (Deprecated)", Type = "830f781d-2522-4ec0-9d6f-ecfc0bf695f6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVectorDeprecated(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Up Vector (Deprecated)", Type = "830f781d-2522-4ec0-9d6f-ecfc0bf695f6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocity(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Velocity", Type = "0310de62-2ede-4af0-b551-0228290fc54c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocity(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Velocity", Type = "0310de62-2ede-4af0-b551-0228290fc54c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocityDeprecated(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Get Velocity (Deprecated)", Type = "e9c65fbe-9d0f-4373-bd45-fe620de801b4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocityDeprecated(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Get Velocity (Deprecated)", Type = "e9c65fbe-9d0f-4373-bd45-fe620de801b4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GoToRoom(PlayerPort Player, DestinationRoomPort Destination)
        {
            Node node = new Node()
            {Name = "Go To Room", Type = "bad6a57b-2af8-4526-8caa-e07476da4a5b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Destination, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GoToState(StatePort State)
        {
            Node node = new Node()
            {Name = "Go To State", Type = "ecf53690-1d60-4971-b057-f601d49975ab", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, State, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort HasHeldObject, RecRoomObjectPort HeldObject) GrabberGetHeldObject(GrabberPort Target)
        {
            Node node = new Node()
            {Name = "Grabber Get Held Object", Type = "338a3300-ad0d-40d9-a9a7-ff57f5401905", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort GrabberGrabObject(GrabberPort Target, RecRoomObjectPort Object, BoolPort StealfromPlayer, BoolPort SnaptoGrabber)
        {
            Node node = new Node()
            {Name = "Grabber Grab Object", Type = "36668004-5384-44df-901e-bd3324675838", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, StealfromPlayer, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SnaptoGrabber, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static RecRoomObjectPort GrabberRelease(GrabberPort Target)
        {
            Node node = new Node()
            {Name = "Grabber Release", Type = "051648c8-f13b-4e75-b5e0-33fc834485c6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void GrabberSetPlayerCanStealFromGrabber(GrabberPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Grabber Set Player Can Steal From Grabber", Type = "a02cf9d4-fa6b-41c7-bcbb-262489fa52ad", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort GrantReward(PlayerPort Player, RewardPort Reward, AlternativeExec<BoolPort> OnAwardComplete)
        {
            Node node = new Node()
            {Name = "Grant Reward", Type = "8b38e01f-9c85-47bb-abda-85e354c15d41", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Reward, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnAwardComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort GraphGetIsActive()
        {
            Node node = new Node()
            {Name = "Graph Get Is Active", Type = "539cb9a4-39a4-4932-8f36-b249748cff9e", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterOrEqual(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "f3ced0d8-396e-4311-a807-8ffd9b147060", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterOrEqual(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "f3ced0d8-396e-4311-a807-8ffd9b147060", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThan(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "65aa2570-98b8-413b-a9a9-2eae9f562871", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThan(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "65aa2570-98b8-413b-a9a9-2eae9f562871", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThanDeprecated(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "110c29b1-ac90-4a71-b3c0-53372aa134bc", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThanDeprecated(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "110c29b1-ac90-4a71-b3c0-53372aa134bc", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThanOrEqualDeprecated(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "a10e7788-f016-4390-a68e-87d93b47edb1", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThanOrEqualDeprecated(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "a10e7788-f016-4390-a68e-87d93b47edb1", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GroundVehicleAddBoostFuel(GroundVehiclePort Target, IntPort Boostamount)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Add Boost Fuel", Type = "dc78ca9e-29c4-4cba-a6cb-3ea87ffbe780", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Boostamount, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleApplyBoost(GroundVehiclePort Target, AlternativeExec Failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Apply Boost", Type = "29dd429b-81e5-40c7-b3b6-8d03bcc1eec3", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static IntPort GroundVehicleGetBoostFuel(GroundVehiclePort Target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Boost Fuel", Type = "76d46244-7b8e-43de-bd8c-55375411ffe1", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GroundVehicleGetDrivingEnabled(GroundVehiclePort Target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Driving Enabled", Type = "f41ae49a-dbf3-4b4b-87dc-68614da242cc", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GroundVehicleGetEngineTorqueMultiplier(GroundVehiclePort Target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Engine Torque Multiplier", Type = "390257d5-e382-4416-81f7-40562d5473d3", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GroundVehicleGetSeatedPlayer(GroundVehiclePort Target, IntPort Seatindex)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Seated Player", Type = "d150c8fa-91fd-4483-a8b5-ca6c62f2c648", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Seatindex, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GroundVehicleGetWheelFrictionMultiplier(GroundVehiclePort Target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Wheel Friction Multiplier", Type = "0fcc3c15-5ee0-4af9-a4de-94627fbba6ec", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GroundVehicleSetDrivingEnabled(GroundVehiclePort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Driving Enabled", Type = "6c7a86cc-2145-404c-b029-31d22f9811e7", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleSetEngineTorqueMultiplier(GroundVehiclePort Target, FloatPort Torquemultiplier)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Engine Torque Multiplier", Type = "128116c8-591f-44bc-97cd-f787d660cfb5", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Torquemultiplier, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleSetSeatedPlayer(GroundVehiclePort Target, IntPort Seatindex, PlayerPort Player, AlternativeExec Failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Seated Player", Type = "50458d97-a7cf-45e3-892b-fb67c0fbe64b", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Seatindex, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void GroundVehicleSetWheelFrictionMultiplier(GroundVehiclePort Target, FloatPort Frictionmultiplier)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Wheel Friction Multiplier", Type = "d00aed86-97ac-4717-872e-ca6646ee266d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Frictionmultiplier, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleUnseatPlayer(GroundVehiclePort Target, PlayerPort Player, AlternativeExec Failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Unseat Player", Type = "5815406b-a3f2-471e-88ec-dffc212293be", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void GroundVehicleUnseatPlayerFromSeat(GroundVehiclePort Target, IntPort Seatindex, AlternativeExec Failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Unseat Player From Seat", Type = "4bb12ec4-780e-4186-a597-36bdc5c67b43", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Seatindex, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void GunHandleAddAutoAimRole(GunHandlePort Target, StringPort Role)
        {
            Node node = new Node()
            {Name = "Gun Handle Add Auto Aim Role", Type = "5db71859-228a-41d9-8742-99bf9aa1df2a", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleApplyRecoil(GunHandlePort Target, FloatPort AngleX, FloatPort AngleY, FloatPort Duration, FloatPort ReturnDuration)
        {
            Node node = new Node()
            {Name = "Gun Handle Apply Recoil", Type = "dca5d998-4ce5-4121-9915-bc4f54df595d", InputCount = 6};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, AngleX, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, AngleY, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ReturnDuration, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort GunHandleGetCurrentAmmo(GunHandlePort Target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Current Ammo", Type = "9e2bb0fe-6179-4ffc-92df-6f3b43bca52d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GunHandleGetFiringDirection(GunHandlePort Target, RecRoomObjectPort Source)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Firing Direction", Type = "1521eb32-29db-4708-81de-71398c29e76d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Source, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GunHandleGetIsReloading(GunHandlePort Target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Is Reloading", Type = "f3ef0346-e593-47c9-85f0-f551efe0a9b6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GunHandleGetMaxAmmo(GunHandlePort Target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Max Ammo", Type = "0d6de11b-5487-4e61-9b4b-d6719b3aeb0f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GunHandleGetRateOfFire(GunHandlePort Target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Rate Of Fire", Type = "a06ad097-0666-42ff-ab3d-0f00c383e9a1", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GunHandleGetReloadDuration(GunHandlePort Target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Reload Duration", Type = "ce696294-0c85-4823-8fe3-5fd6a41df2c9", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GunHandleGetSupportsReload(GunHandlePort Target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Supports Reload", Type = "ec1f7c92-8484-4d00-b820-32726299f67a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GunHandleRemoveAutoAimRole(GunHandlePort Target, StringPort Role)
        {
            Node node = new Node()
            {Name = "Gun Handle Remove Auto Aim Role", Type = "16e9da8d-137b-4b51-bc8c-12b32314363b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetADSEnabled(GunHandlePort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Gun Handle Set ADS Enabled", Type = "eaab4d32-95ed-4c98-83bd-fa9d99300255", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetAutoAimRoles(GunHandlePort Target, ListPort<StringPort> Roles)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Auto Aim Roles", Type = "e9c22501-3d32-4f9e-a6fb-322bad4eaca1", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Roles, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetCurrentAmmo(GunHandlePort Target, IntPort Ammo)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Current Ammo", Type = "75c94e14-2fd9-4097-93c4-ee5b56a27b64", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Ammo, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetMaxAmmo(GunHandlePort Target, IntPort MaxAmmo)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Max Ammo", Type = "d0ace61e-9d6f-440a-839c-65a3e6aa1e9b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxAmmo, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetRateOfFire(GunHandlePort Target, FloatPort RateOfFire)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Rate Of Fire", Type = "0f501beb-e2d2-471b-a8f9-054ac8e006ca", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, RateOfFire, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetReloadDuration(GunHandlePort Target, FloatPort ReloadDuration)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Reload Duration", Type = "c03abed2-ec9b-494b-89c2-9bbf741d490f", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ReloadDuration, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetSupportsReload(GunHandlePort Target, BoolPort CanReload)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Supports Reload", Type = "27566004-ad66-4498-91d9-5e29b1f35d2e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, CanReload, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort HasTag(PlayerPort Target, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Has Tag", Type = "bc3011d2-c085-490e-a450-195ff3a27009", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort HasTag(RecRoomObjectPort Target, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Has Tag", Type = "bc3011d2-c085-490e-a450-195ff3a27009", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort HolsterObject(PlayerPort Player, RecRoomObjectPort ObjectToHolster, BoolPort ForceHolster, BoolPort Steal)
        {
            Node node = new Node()
            {Name = "Holster Object", Type = "d619a625-f624-491a-9f53-3bf969f1ae14", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ObjectToHolster, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, ForceHolster, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Steal, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static ColorPort HSVToColor(FloatPort Hue, FloatPort Saturation, FloatPort Value)
        {
            Node node = new Node()
            {Name = "HSV To Color", Type = "2e8d2d58-a73d-407a-9892-6cac4cb9ce9a", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Hue, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Saturation, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void If(BoolPort Condition, AlternativeExec Else)
        {
            Node node = new Node()
            {Name = "If", Type = "7adc6ab1-fcab-4746-aec6-006352e29cdc", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Condition, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Else();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfHasTag(PlayerPort Target, StringPort Tag, AlternativeExec DoesNotHaveTag)
        {
            Node node = new Node()
            {Name = "If Has Tag", Type = "f64272d9-4aca-4170-8dee-bb711d97921c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            DoesNotHaveTag();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfHasTag(RecRoomObjectPort Target, StringPort Tag, AlternativeExec DoesNotHaveTag)
        {
            Node node = new Node()
            {Name = "If Has Tag", Type = "f64272d9-4aca-4170-8dee-bb711d97921c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            DoesNotHaveTag();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfLocalPlayerIsAuthority(AlternativeExec ImNotAuthority)
        {
            Node node = new Node()
            {Name = "If Local Player Is Authority", Type = "b8b667b9-7b55-4b8d-b116-abef220777e2", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            ImNotAuthority();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfLocalPlayerIsRoomAuthority(AlternativeExec ImNotAuthority)
        {
            Node node = new Node()
            {Name = "If Local Player Is Room Authority", Type = "5e28057f-214b-4ff8-81bc-512be207c9d7", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            ImNotAuthority();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfLocalPlayerShouldRun(PlayerPort ActingPlayer, AlternativeExec ShouldNotRun)
        {
            Node node = new Node()
            {Name = "If Local Player Should Run", Type = "6d69bee8-0d77-4d5f-bf35-9794eaaabe81", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, ActingPlayer, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            ShouldNotRun();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerHasRole(PlayerPort Player, StringPort Role, AlternativeExec DoesNotHaveRole)
        {
            Node node = new Node()
            {Name = "If Player Has Role", Type = "502d09f5-85ce-45fc-b6a1-3a3eecce8562", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            DoesNotHaveRole();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerIsLocal(PlayerPort Player, AlternativeExec IsNotLocal)
        {
            Node node = new Node()
            {Name = "If Player Is Local", Type = "c7643011-f320-4155-89b8-d693730c1935", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            IsNotLocal();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerIsValid(PlayerPort Player, AlternativeExec IsNotValid)
        {
            Node node = new Node()
            {Name = "If Player Is Valid", Type = "ec2ceb32-db91-4f65-8b0a-b66d7f2a7f2d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            IsNotValid();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerIsValidAndLocal(PlayerPort Player, AlternativeExec IsNotValid, AlternativeExec IsValidAndNotLocal)
        {
            Node node = new Node()
            {Name = "If Player Is Valid And Local", Type = "c1049bfc-902d-4a1a-8b28-1a80b6f26588", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            IsNotValid();
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            IsValidAndNotLocal();
            ExecFlow.current = mainFlow;
            return;
        }

        public static T IfValue<T>(BoolPort If, T Then, T Else)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "If Value", Type = "a4f8a9a1-fd7b-4702-8345-93ae4d57f333", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, If, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Then, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Else, new Port{Node = node, Index = 2});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void In()
        {
            Node node = new Node()
            {Name = "In", Type = "13e02b88-46f5-4602-9735-8856aeb3eb7b", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static BoolPort InstanceGetIsEvent()
        {
            Node node = new Node()
            {Name = "Instance Get Is Event", Type = "f24d537e-da9e-47bf-8764-fba6eeefb043", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InstanceGetIsPrivate()
        {
            Node node = new Node()
            {Name = "Instance Get Is Private", Type = "aa263220-c6aa-4789-b09c-c73d7fa144fd", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort InstanceGetMaxPlayers()
        {
            Node node = new Node()
            {Name = "Instance Get Max Players", Type = "af660f62-d086-4731-ab9d-9a8e8a25c77e", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InteractionVolumeGetHoldTime(InteractionVolumePort Target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Hold Time", Type = "90e2d8e3-6cdc-4b52-b7e9-529c98e5ee09", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort InteractionVolumeGetInteractionPrompt(InteractionVolumePort Target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Interaction Prompt", Type = "0c351297-db4d-43e7-81a3-95dc5ddde401", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InteractionVolumeGetIsLocked(InteractionVolumePort Target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Is Locked", Type = "c536089c-e2c3-4a6a-a4fa-aba8dca6b810", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InteractionVolumeGetNormalizedHoldProgress(InteractionVolumePort Target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Normalized Hold Progress", Type = "4cdfcf23-e5dc-4b81-a500-189dba609d0f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void InteractionVolumeSetHoldTime(InteractionVolumePort Target, FloatPort HoldTime)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Hold Time", Type = "47546f8a-f7b9-4b8a-a4a6-1298f130f65c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, HoldTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InteractionVolumeSetInteractionPrompt(InteractionVolumePort Target, StringPort InteractionPrompt)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Interaction Prompt", Type = "380d8467-bdfa-4724-a62c-1955831f994a", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, InteractionPrompt, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InteractionVolumeSetLocked(InteractionVolumePort Target, BoolPort Locked)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Locked", Type = "a1e57113-f0b5-45c5-b1e0-95163674daa4", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Locked, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InteractionVolumeSetNormalizedHoldProgress(InteractionVolumePort Target, FloatPort NormalizedHoldProgress)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Normalized Hold Progress", Type = "714654bc-7266-4088-8efe-287bdca164fd", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, NormalizedHoldProgress, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort IntToFloat(IntPort Value)
        {
            Node node = new Node()
            {Name = "Int to Float", Type = "65cfba8a-b5dc-4946-b824-e6efc5719f3a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort IntVariable(IntPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "int Variable", Type = "33224907-68ff-4102-802e-7c3eed481d37", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalCount) InventoryItemAdd(InventoryItemPort InventoryItem, PlayerPort Player, IntPort Quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> Complete)
        {
            Node node = new Node()
            {Name = "Inventory Item Add", Type = "41d040f2-f8c6-45ec-b6c8-2c31a95e6951", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Quantity, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static InventoryItemPort InventoryItemConstant()
        {
            Node node = new Node()
            {Name = "Inventory Item Constant", Type = "04cc0f81-b7d4-4469-aaa4-428b6e0c1f02", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new InventoryItemPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort InventoryItemGetCount(InventoryItemPort InventoryItem, PlayerPort Player, AlternativeExec<IntPort> Complete)
        {
            Node node = new Node()
            {Name = "Inventory Item Get Count", Type = "2e1cb4fa-a341-40fe-acba-e8621f7c69ca", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (StringPort Name, StringPort Description, BoolPort SupportsUseAction) InventoryItemGetDefinition(InventoryItemPort InventoryItem)
        {
            Node node = new Node()
            {Name = "Inventory Item Get Definition", Type = "93ad7158-81eb-453c-b3db-222b9630ae0e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 0});
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new StringPort{Port = new Port{Node = node, Index = 1}}, new BoolPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalCount) InventoryItemRemove(InventoryItemPort InventoryItem, PlayerPort Player, IntPort Quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> Complete)
        {
            Node node = new Node()
            {Name = "Inventory Item Remove", Type = "736abfd6-5a44-4c74-9fc2-663adf6cbbdf", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Quantity, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void InventoryItemUse(InventoryItemPort InventoryItem)
        {
            Node node = new Node()
            {Name = "Inventory Item Use", Type = "ead258fa-43c8-4504-b5e5-1dc5bf47c7c7", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort InverseLerp(FloatPort Start, FloatPort End, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp", Type = "9d811bd5-2a4a-4368-80ea-635004b6c06b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerp(ColorPort Start, ColorPort End, ColorPort Value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp", Type = "9d811bd5-2a4a-4368-80ea-635004b6c06b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerp(Vector3Port Start, Vector3Port End, Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp", Type = "9d811bd5-2a4a-4368-80ea-635004b6c06b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerpUnclamped(FloatPort Start, FloatPort End, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp Unclamped", Type = "d33e7a63-ec6b-40b2-9f81-ab110457a9f2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerpUnclamped(ColorPort Start, ColorPort End, ColorPort Value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp Unclamped", Type = "d33e7a63-ec6b-40b2-9f81-ab110457a9f2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerpUnclamped(Vector3Port Start, Vector3Port End, Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp Unclamped", Type = "d33e7a63-ec6b-40b2-9f81-ab110457a9f2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InvisibleCollisionGetBlocksPlayers(InvisibleCollisionPort Target)
        {
            Node node = new Node()
            {Name = "Invisible Collision Get Blocks Players", Type = "0938d870-2f6d-4144-ba3d-c73af0e46348", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InvisibleCollisionGetEnabled(InvisibleCollisionPort Target)
        {
            Node node = new Node()
            {Name = "Invisible Collision Get Enabled", Type = "de407f3c-2fb0-4c9a-9dc4-fb6d6709737e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void InvisibleCollisionSetBlocksPlayers(InvisibleCollisionPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Invisible Collision Set Blocks Players", Type = "ed61effe-a684-4c1a-92c8-79fc6df010fb", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InvisibleCollisionSetEnabled(InvisibleCollisionPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Invisible Collision Set Enabled", Type = "a5b78c7e-d718-44d4-91c4-7f795bf73814", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort IsValid<T>(T Port0)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Is Valid", Type = "24a1be50-ef1b-4e54-836b-4a2a95780b4e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort LaserPointerGetColor(LaserPointerPort Target)
        {
            Node node = new Node()
            {Name = "Laser Pointer Get Color", Type = "cb035f05-f3dc-4550-bd64-27cb96bd6be0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LaserPointerGetEnabled(LaserPointerPort Target)
        {
            Node node = new Node()
            {Name = "Laser Pointer Get Enabled", Type = "54fc909a-a864-4e89-be6e-e7f92b7f275a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LaserPointerGetLength(LaserPointerPort Target)
        {
            Node node = new Node()
            {Name = "Laser Pointer Get Length", Type = "a839c882-9317-4b99-92e6-c3815532b479", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LaserPointerSetColor(LaserPointerPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Laser Pointer Set Color", Type = "1fe56621-d070-43bd-a268-13538b401356", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LaserPointerSetEnabled(LaserPointerPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Laser Pointer Set Enabled", Type = "92c74863-0142-4c4a-b619-199793b75c3b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LaserPointerSetLength(LaserPointerPort Target, FloatPort Length)
        {
            Node node = new Node()
            {Name = "Laser Pointer Set Length", Type = "085cb783-a29a-4e0e-93ba-c86b4bff4856", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Length, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort LeaderboardGetPlayerStat(PlayerPort Player, IntPort Channel, AlternativeExec<IntPort> OnGetStatComplete)
        {
            Node node = new Node()
            {Name = "Leaderboard Get Player Stat", Type = "12cf9781-1e1b-4e59-a783-c7214b66be8a", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Channel, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnGetStatComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void LeaderboardSetLocalPlayerStat(IntPort Channel, IntPort Value)
        {
            Node node = new Node()
            {Name = "Leaderboard Set Local Player Stat", Type = "57a1553a-ba24-4422-903a-e610a03e7994", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Channel, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Lerp(FloatPort Start, FloatPort End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort Lerp(QuaternionPort Start, QuaternionPort End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Lerp(Vector3Port Start, Vector3Port End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort Lerp(ColorPort Start, ColorPort End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LerpUnclamped(FloatPort Start, FloatPort End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort LerpUnclamped(QuaternionPort Start, QuaternionPort End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port LerpUnclamped(Vector3Port Start, Vector3Port End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort LerpUnclamped(ColorPort Start, ColorPort End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessOrEqual(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "8c78eedf-f79e-4f70-b187-65092893d1b6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessOrEqual(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "8c78eedf-f79e-4f70-b187-65092893d1b6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThan(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "a05cd0de-609a-4d92-93ad-65b635306233", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThan(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "a05cd0de-609a-4d92-93ad-65b635306233", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThanDeprecated(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "7e58b3f4-2694-4ced-b3a8-0fe23f48f60f", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThanDeprecated(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "7e58b3f4-2694-4ced-b3a8-0fe23f48f60f", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThanOrEqualDeprecated(IntPort A, IntPort B)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "a027073f-9189-457f-a53d-8562e8829daf", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThanOrEqualDeprecated(FloatPort A, FloatPort B)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "a027073f-9189-457f-a53d-8562e8829daf", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, A, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, B, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetAngle(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Get Angle", Type = "8a6c0623-7585-402c-8734-7fa7248b15a0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort LightGetColor(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Get Color", Type = "bc45bb9f-619a-48c4-a3ed-14596c83424f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LightGetEnabled(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Get Enabled", Type = "d5eafcf1-1762-4ece-bc31-7e2eddac253e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetIntensity(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Get Intensity", Type = "67bf3eac-2273-4345-94b3-8288f63f9a0e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetRange(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Get Range", Type = "e218e55a-3307-4839-a3d4-b7cc72e1e3bc", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetSoftness(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Get Softness", Type = "afc674dc-06b5-44fc-9d01-95d8ca56db41", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetSpecularContribution(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Get Specular Contribution", Type = "b7e74ebc-9ed7-4302-abf1-d2fe42b92a6d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LightSetAngle(LightPort Target, FloatPort Angle)
        {
            Node node = new Node()
            {Name = "Light Set Angle", Type = "494ceaa7-3520-4f5b-87e0-7dd08334730c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Angle, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetAngleInt(LightPort Target, IntPort Angle)
        {
            Node node = new Node()
            {Name = "Light Set Angle", Type = "873d8765-9dc7-41ea-87ef-dd6e32119af8", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Angle, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetColor(LightPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Light Set Color", Type = "b2698906-68bd-4ea3-be98-35a23615b522", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetColorId(LightPort Target, IntPort Color)
        {
            Node node = new Node()
            {Name = "Light Set Color Id", Type = "2b6d9368-2ddc-41fb-ac14-b1a3561b19fc", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetIntensity(LightPort Target, FloatPort Intensity)
        {
            Node node = new Node()
            {Name = "Light Set Intensity", Type = "aa6dc013-3f5b-45f4-87a2-8aa4d16cc375", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Intensity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetIntensityInt(LightPort Target, IntPort Intensity)
        {
            Node node = new Node()
            {Name = "Light Set Intensity", Type = "902a47c8-3834-4858-bbae-5357281a507d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Intensity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetRange(LightPort Target, FloatPort Range)
        {
            Node node = new Node()
            {Name = "Light Set Range", Type = "214bb1b7-f808-4a36-9c10-113045b4fe44", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Range, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetRangeInt(LightPort Target, IntPort Range)
        {
            Node node = new Node()
            {Name = "Light Set Range", Type = "c3d0ef1f-921c-4602-a6eb-b03ed46d556f", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Range, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetSoftness(LightPort Target, FloatPort Softness)
        {
            Node node = new Node()
            {Name = "Light Set Softness", Type = "7876451d-982d-4880-b78b-b3d02389af2c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Softness, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetSpecularContribution(LightPort Target, FloatPort SpecularContribution)
        {
            Node node = new Node()
            {Name = "Light Set Specular Contribution", Type = "723817f6-9562-4f36-b3cc-1c66da5ac3c6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, SpecularContribution, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightTurnOff(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Turn Off", Type = "0f96406e-af69-4f6c-a430-c6b004457ef4", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightTurnOn(LightPort Target)
        {
            Node node = new Node()
            {Name = "Light Turn On", Type = "5452c480-62f9-4d4e-b615-0f59e645d8db", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListAdd<T>(ListPort<T> Target, T Item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Add", Type = "f716c3f3-0c7c-42a4-bf55-12b7e1cd9040", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort ListAllTrue(ListPort<BoolPort> Target)
        {
            Node node = new Node()
            {Name = "List All True", Type = "7d474bd7-ee53-4e6d-a45f-cd64fce1c0dc", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ListAnyTrue(ListPort<BoolPort> Target)
        {
            Node node = new Node()
            {Name = "List Any True", Type = "f9589495-685e-4e14-af2e-5cd45f860021", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<BoolPort> ListBoolVariable(ListPort<BoolPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<bool> Variable", Type = "e0ef8c83-e5a6-4272-a102-07bfc0a40fd5", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<BoolPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void ListClear<T>(ListPort<T> List)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Clear", Type = "2314f2f2-979b-4d4a-ab02-fc3e7fdddad6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, List, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<ColorPort> ListColorVariable(ListPort<ColorPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Color> Variable", Type = "9216dded-da74-49a7-a327-5750f4809787", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<ColorPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<T> ListConcat<T>(ListPort<T> List1, ListPort<T> List2)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Concat", Type = "0e2f21e0-bc71-423a-a983-72e27193ca8b", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, List1, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, List2, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ListContains<T>(ListPort<T> Target, T Item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Contains", Type = "73f261e2-d65d-4607-858d-3f4c37c76963", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<T> ListCopy<T>(ListPort<T> Target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Copy", Type = "b336b889-407a-45c8-ad82-a89f4e033c05", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static ListPort<T> ListCreate<T>(T Item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Create", Type = "542d3256-0d51-4c33-a2a1-fbc44b7e1f07", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<DestinationRoomPort> ListDestinationRoomVariable(ListPort<DestinationRoomPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Destination Room> Variable", Type = "fff164aa-d775-4d67-a6b0-d1396cb74161", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<DestinationRoomPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort ListDivide(ListPort<FloatPort> Target)
        {
            Node node = new Node()
            {Name = "List Divide", Type = "7e5af908-533d-4d42-b3c9-0159e2b5fd55", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListDivide(ListPort<IntPort> Target)
        {
            Node node = new Node()
            {Name = "List Divide", Type = "7e5af908-533d-4d42-b3c9-0159e2b5fd55", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListDivide(ListPort<Vector3Port> Target)
        {
            Node node = new Node()
            {Name = "List Divide", Type = "7e5af908-533d-4d42-b3c9-0159e2b5fd55", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<FloatPort> ListFloatVariable(ListPort<FloatPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<float> Variable", Type = "9bcd36e6-c293-432a-8d90-f6391fe06c62", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<FloatPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<IntPort> ListGetAllIndicesOf<T>(ListPort<T> Target, T Item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get All Indices Of", Type = "09066fc7-c88e-49f2-992c-5ed10f4ee682", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<IntPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListGetCount<T>(ListPort<T> List)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get Count", Type = "0493204d-9815-49a9-8c87-4dedf5ccf7e8", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, List, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static T ListGetElement<T>(ListPort<T> List, IntPort Index)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get Element", Type = "e8c5082f-0a75-4025-9679-293bc8d72989", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, List, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Index, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListGetFirstIndexOf<T>(ListPort<T> Target, T Item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get First Index Of", Type = "d8926108-6c7d-4c78-8fbd-baac2b210e03", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ListInsert<T>(ListPort<T> Target, T Item, IntPort Index)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Insert", Type = "592c8aab-9489-492f-a4aa-1e558e6a8ce7", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Index, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<IntPort> ListIntVariable(ListPort<IntPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<int> Variable", Type = "fe2f9c12-d213-4234-a387-9d2ec1ad7fc1", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<IntPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort ListMax(ListPort<FloatPort> Target)
        {
            Node node = new Node()
            {Name = "List Max", Type = "47428133-4492-422a-aeab-82c21667543e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListMax(ListPort<IntPort> Target)
        {
            Node node = new Node()
            {Name = "List Max", Type = "47428133-4492-422a-aeab-82c21667543e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ListMin(ListPort<FloatPort> Target)
        {
            Node node = new Node()
            {Name = "List Min", Type = "73e9cc79-66cc-4526-8ed7-87500e208c6b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListMin(ListPort<IntPort> Target)
        {
            Node node = new Node()
            {Name = "List Min", Type = "73e9cc79-66cc-4526-8ed7-87500e208c6b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ListMultiply(ListPort<FloatPort> Target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListMultiply(ListPort<IntPort> Target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort ListMultiply(ListPort<QuaternionPort> Target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListMultiply(ListPort<Vector3Port> Target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<ObjectiveMarkerPort> ListObjectiveMarkerVariable(ListPort<ObjectiveMarkerPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Objective Marker> Variable", Type = "2aa2fe68-18bf-4f63-9ed9-2fc237b60df9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<ObjectiveMarkerPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<PlayerPort> ListPlayerVariable(ListPort<PlayerPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Player> Variable", Type = "32837e14-12de-465f-89dc-ceddb64cdd6c", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<QuaternionPort> ListQuaternionVariable(ListPort<QuaternionPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Quaternion> Variable", Type = "e8cfde19-33a4-4826-a032-4b9bd50aa171", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<QuaternionPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> ListRecRoomObjectVariable(ListPort<RecRoomObjectPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Rec Room Object> Variable", Type = "536e376c-087d-4909-9412-3fcee5d6f52b", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void ListRemoveAt<T>(ListPort<T> Target, IntPort Index)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove At", Type = "02774487-d41a-4b59-9aa9-2aeb0aad9e37", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Index, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListRemoveItemAll<T>(ListPort<T> Target, T Item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove Item (All)", Type = "370f1016-69e0-4265-a4a2-7841067f1fa7", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort ListRemoveItemFirst<T>(ListPort<T> Target, T Item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove Item (First)", Type = "1657cd3d-6bc5-41d2-b70f-1854f9288ffa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Item, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void ListRemoveLast<T>(ListPort<T> Target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove Last", Type = "2687fb17-96ea-4106-94d7-be8854cfa978", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<RewardPort> ListRewardVariable(ListPort<RewardPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Reward> Variable", Type = "40a49ce8-a734-4e3e-bb59-00a4698a942e", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<RewardPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void ListSetElement<T>(ListPort<T> List, IntPort Index, T Value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Set Element", Type = "88daacc5-7652-4d3a-b505-ba256ce3fd9d", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, List, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Index, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListShuffle<T>(ListPort<T> Target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Shuffle", Type = "26a97d16-34e6-48c7-83a3-6cf74c1e4985", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListSort(ListPort<FloatPort> Target, BoolPort Ascending)
        {
            Node node = new Node()
            {Name = "List Sort", Type = "cc967d66-b201-464e-bddd-a7cf47124fec", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Ascending, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListSort(ListPort<IntPort> Target, BoolPort Ascending)
        {
            Node node = new Node()
            {Name = "List Sort", Type = "cc967d66-b201-464e-bddd-a7cf47124fec", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Ascending, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListSort(ListPort<StringPort> Target, BoolPort Ascending)
        {
            Node node = new Node()
            {Name = "List Sort", Type = "cc967d66-b201-464e-bddd-a7cf47124fec", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Ascending, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<StringPort> ListStringVariable(ListPort<StringPort> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<string> Variable", Type = "94fb596f-6b3f-4981-bc2d-1bb693c45ae6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort ListSubtract(ListPort<FloatPort> Target)
        {
            Node node = new Node()
            {Name = "List Subtract", Type = "20f069cb-30e5-4df8-8e2f-d91f322a83dd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListSubtract(ListPort<IntPort> Target)
        {
            Node node = new Node()
            {Name = "List Subtract", Type = "20f069cb-30e5-4df8-8e2f-d91f322a83dd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListSubtract(ListPort<Vector3Port> Target)
        {
            Node node = new Node()
            {Name = "List Subtract", Type = "20f069cb-30e5-4df8-8e2f-d91f322a83dd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ListSum(ListPort<FloatPort> Target)
        {
            Node node = new Node()
            {Name = "List Sum", Type = "d080c9af-402f-4eb9-91d6-9eee945bf734", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListSum(ListPort<IntPort> Target)
        {
            Node node = new Node()
            {Name = "List Sum", Type = "d080c9af-402f-4eb9-91d6-9eee945bf734", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListSum(ListPort<Vector3Port> Target)
        {
            Node node = new Node()
            {Name = "List Sum", Type = "d080c9af-402f-4eb9-91d6-9eee945bf734", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<Vector3Port> ListVector3Variable(ListPort<Vector3Port> Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Vector3> Variable", Type = "35f84cfc-b10e-451e-832e-c6ad8d99685d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<Vector3Port>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void LocalPlayerDisableInteractionWithTargetPlayer(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Local Player Disable Interaction with Target Player", Type = "f99b0a80-f3a6-4e2d-8101-afe3d9e1008d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerEnableInteractionWithTargetPlayer(PlayerPort Player, FloatPort RequiredHoldDuration, StringPort Prompt)
        {
            Node node = new Node()
            {Name = "Local Player Enable Interaction with Target Player", Type = "47455638-8ac9-4b9c-8201-20a12d43d513", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, RequiredHoldDuration, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Prompt, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static Vector3Port LocalPlayerGazeDirection()
        {
            Node node = new Node()
            {Name = "Local Player Gaze Direction", Type = "6b68c3d8-8e26-43d2-bd6d-37944ae80963", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port LocalPlayerGazeOrigin()
        {
            Node node = new Node()
            {Name = "Local Player Gaze Origin", Type = "44d9ad9e-8f31-4588-903d-1bbe8d3c3b70", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (StringPort HeaderText, ColorPort HeaderTextColor, StringPort BodyText, ColorPort BodyTextColor) LocalPlayerGetObjectiveLogContent()
        {
            Node node = new Node()
            {Name = "Local Player Get Objective Log Content", Type = "809ba66c-8877-4d74-ac4b-2d0730a1b576", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new ColorPort{Port = new Port{Node = node, Index = 1}}, new StringPort{Port = new Port{Node = node, Index = 2}}, new ColorPort{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static BoolPort LocalPlayerGetObjectiveLogEnabled()
        {
            Node node = new Node()
            {Name = "Local Player Get Objective Log Enabled", Type = "ab20a5af-2d16-494c-b376-0fb5d2c59258", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LocalPlayerSetObjectiveLogContent(StringPort HeaderText, ColorPort HeaderTextColor, StringPort BodyText, ColorPort BodyTextColor)
        {
            Node node = new Node()
            {Name = "Local Player Set Objective Log Content", Type = "a060bad3-3111-4b9d-add3-5e6af3a4a151", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, HeaderText, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, HeaderTextColor, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, BodyText, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, BodyTextColor, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerSetObjectiveLogEnabled(BoolPort Enable)
        {
            Node node = new Node()
            {Name = "Local Player Set Objective Log Enabled", Type = "5013021c-3243-4cc2-bd39-06abddb38c9c", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Enable, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerSetPlayerNametagVisibility(PlayerPort Player, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Local Player Set Player Nametag Visibility", Type = "a73655df-b37b-4c02-a19a-4eb05ce75a14", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Logarithm(FloatPort Value, FloatPort Base)
        {
            Node node = new Node()
            {Name = "Logarithm", Type = "28a105ab-a947-4493-a51d-ced76a9601ee", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Base, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LogError(StringPort Error)
        {
            Node node = new Node()
            {Name = "Log Error", Type = "5aadca49-47b3-423e-b536-6b41b0acbfde", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Error, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, null);
            return;
        }

        public static void LogString(StringPort Text)
        {
            Node node = new Node()
            {Name = "Log String", Type = "4047a8cc-3dcc-4fa8-85a7-41d569b8e547", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Text, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RRTuplePort<T0, T1> MakeTuple<T0, T1>(T0 Item1, T1 Item2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Make Tuple", Type = "bee72c1d-266b-4ea4-b185-7500618030c6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Item1, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Item2, new Port{Node = node, Index = 1});
            var output_ports = new RRTuplePort<T0, T1>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Max(IntPort Value)
        {
            Node node = new Node()
            {Name = "Max", Type = "1cb807b1-85e7-4c14-b3ae-5775b7873b7d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Max(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Max", Type = "1cb807b1-85e7-4c14-b3ae-5775b7873b7d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Min(IntPort Value)
        {
            Node node = new Node()
            {Name = "Min", Type = "bfb1ad17-5ade-4bd8-9c31-6d4b1e47dae3", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Min(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Min", Type = "bfb1ad17-5ade-4bd8-9c31-6d4b1e47dae3", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Modulo(IntPort Value)
        {
            Node node = new Node()
            {Name = "Modulo", Type = "fe462e79-9e9f-4234-b594-7b6c0a69329b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Modulo(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Modulo", Type = "fe462e79-9e9f-4234-b594-7b6c0a69329b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Multiply(IntPort Value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Multiply(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static QuaternionPort Multiply(QuaternionPort Value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Multiply(Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static AudioPort MusicConstant()
        {
            Node node = new Node()
            {Name = "Music Constant", Type = "ce3cbe60-7983-4458-b44a-738ea7036155", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort Nand(BoolPort Input)
        {
            Node node = new Node()
            {Name = "Nand", Type = "502e86d1-5b3a-4213-97e2-df25836ffcc4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Noise(Vector3Port Point)
        {
            Node node = new Node()
            {Name = "Noise", Type = "06f8732b-b1cb-4b79-815e-5b389c1dd78f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Point, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort Nor(BoolPort Input)
        {
            Node node = new Node()
            {Name = "Nor", Type = "2891bcb4-a6ab-4a2e-a08d-dd2a55f1cf66", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort Not(BoolPort Value)
        {
            Node node = new Node()
            {Name = "Not", Type = "ff551243-beb4-470e-ab48-9d616818d5e4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarkerPort Target, PlayerPort PlayerOrObject)
        {
            Node node = new Node()
            {Name = "Objective Marker Attach To Player Or Object", Type = "bb7c408a-1fad-4612-a637-0b1a365baa1c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, PlayerOrObject, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarkerPort Target, RecRoomObjectPort PlayerOrObject)
        {
            Node node = new Node()
            {Name = "Objective Marker Attach To Player Or Object", Type = "bb7c408a-1fad-4612-a637-0b1a365baa1c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, PlayerOrObject, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ObjectiveMarkerPort ObjectiveMarkerConstant()
        {
            Node node = new Node()
            {Name = "Objective Marker Constant", Type = "9ffb119b-dadc-4e50-af19-9bfd335a34ef", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new ObjectiveMarkerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort ObjectiveMarkerGetColor(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Color", Type = "7c9d1838-0b70-4a77-8cec-b67758a9095e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ObjectiveMarkerGetCurrentDistance(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Current Distance", Type = "a4ab4e75-1031-4f68-9631-ef31f131c708", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ObjectiveMarkerGetDistanceEnabled(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Distance Enabled", Type = "6bca2a96-0f30-438e-89d8-aa77ffce2b1c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ObjectiveMarkerGetEnabled(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Enabled", Type = "67f3297e-f498-4e87-a170-5f42b59b0b3a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ObjectiveMarkerGetFadeThreshold(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Fade Threshold", Type = "6fe14d02-0382-4f94-a6ef-f3d414015e95", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ObjectiveMarkerGetLabel(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Label", Type = "38569dac-4cbc-487c-9ca6-14e2cc0fbf05", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ObjectiveMarkerGetLabelEnabled(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Label Enabled", Type = "79b28dea-36c7-4c4d-b523-7461667851a2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ObjectiveMarkerGetPosition(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Position", Type = "0a6b285e-cfb2-4112-88c3-ebe2ba3269a5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecRoomObjectPort ObjectiveMarkerGetTargetObject(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Target Object", Type = "0a9761e3-44df-4ede-a1dd-6a8f4eb6a7c1", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort ObjectiveMarkerGetTargetPlayer(ObjectiveMarkerPort Target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Target Player", Type = "f008de51-c5bb-4107-84e8-18a2d5b648bd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ObjectiveMarkerSetColor(ObjectiveMarkerPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Color", Type = "9b701044-a1dc-4d74-830e-f0843b0c7056", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetDistanceEnabled(ObjectiveMarkerPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Distance Enabled", Type = "891ffa52-7430-4ffd-b26d-d067580eae22", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetEnabled(ObjectiveMarkerPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Enabled", Type = "8bc5eda2-94f1-4bae-879c-50f246155922", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetFadeThreshold(ObjectiveMarkerPort Target, FloatPort Proximity)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Fade Threshold", Type = "66e3efeb-c1df-45f2-ba9b-c261f938c80f", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Proximity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetLabel(ObjectiveMarkerPort Target, StringPort Label)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Label", Type = "cc288016-09cf-4371-951c-082bd5adbd37", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Label, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetLabelEnabled(ObjectiveMarkerPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Label Enabled", Type = "d836b2c6-5cd1-43ac-878e-ea886932031d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetPosition(ObjectiveMarkerPort Target, Vector3Port Position)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Position", Type = "89599e52-1537-4696-91ea-fca1eb0ba26a", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static BoolPort Or(BoolPort Input)
        {
            Node node = new Node()
            {Name = "Or", Type = "b5dcded0-eb2b-468d-a4b9-ffb1054f6214", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void Out()
        {
            Node node = new Node()
            {Name = "Out", Type = "312d4f26-9928-45d5-912e-67c85012b1d2", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static ListPort<CollisionDataPort> OverlapBox(Vector3Port Center, Vector3Port Extents, QuaternionPort Orientation, RaycastData config)
        {
            Node node = new Node()
            {Name = "Overlap Box", Type = "5df93bc7-4bb7-44c6-b260-d7b2836436c8", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Center, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Extents, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Orientation, new Port{Node = node, Index = 3});
            var output_ports = new ListPort<CollisionDataPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.RaycastData = config;
            return output_ports;
        }

        public static ListPort<CollisionDataPort> OverlapSphere(Vector3Port Origin, FloatPort Radius, RaycastData config)
        {
            Node node = new Node()
            {Name = "Overlap Sphere", Type = "23ce1dae-7585-43af-92c1-9a72fa5d0101", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Origin, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Radius, new Port{Node = node, Index = 2});
            var output_ports = new ListPort<CollisionDataPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.RaycastData = config;
            return output_ports;
        }

        public static (BoolPort Result, BoolPort ParseSuccess) ParseBool(StringPort String)
        {
            Node node = new Node()
            {Name = "Parse Bool", Type = "92c05ebc-1967-49a4-94b5-2d01fe1e6b85", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (ColorPort Result, BoolPort ParseSuccess) ParseColor(StringPort String)
        {
            Node node = new Node()
            {Name = "Parse Color", Type = "7a36c4b7-fb89-4ddc-a3b2-bff8597f7b17", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = (new ColorPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (FloatPort Result, BoolPort ParseSuccess) ParseFloat(StringPort String)
        {
            Node node = new Node()
            {Name = "Parse Float", Type = "5e25f40a-2b8c-4327-a89c-7a749838da7d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (IntPort Result, BoolPort ParseSuccess) ParseInt(StringPort String)
        {
            Node node = new Node()
            {Name = "Parse Int", Type = "00b49995-a322-47a3-a32b-5530f2ba7fed", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static FloatPort PistonGetAcceleration(PistonPort Target)
        {
            Node node = new Node()
            {Name = "Piston Get Acceleration", Type = "5e002bc3-c667-441c-8098-4df2f956de5b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetDistance(PistonPort Target)
        {
            Node node = new Node()
            {Name = "Piston Get Distance", Type = "e503b0e4-d295-48cc-bf95-1f1a8127a009", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetMaxDistance(PistonPort Target)
        {
            Node node = new Node()
            {Name = "Piston Get Max Distance", Type = "bb702e97-9f40-45cb-b35d-3a2193ab6800", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetSpeed(PistonPort Target)
        {
            Node node = new Node()
            {Name = "Piston Get Speed", Type = "1d989cd3-d6ae-4503-b80e-5e630ec3f308", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetTargetDistance(PistonPort Target)
        {
            Node node = new Node()
            {Name = "Piston Get Target Distance", Type = "639a360e-aeb1-4c5d-8bc1-96bfaea8aef2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PistonSetAcceleration(PistonPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Piston Set Acceleration", Type = "07c316df-cfa1-4ef8-ac3b-d7e9c4795812", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetDistance(PistonPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Piston Set Distance", Type = "283cb154-76e8-4d60-9899-2a50b6e4c093", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetMaxDistance(PistonPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Piston Set Max Distance", Type = "95431866-97f3-43b4-91f3-4bd3574b2b02", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetSpeed(PistonPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Piston Set Speed", Type = "419d2d2f-18f8-4223-b2f7-a7d1450c242c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetTargetDistance(PistonPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Piston Set Target Distance", Type = "bf25fab6-14ef-4815-a7db-92d99fc627d3", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayAudioAtPosition(AudioPort Audio, Vector3Port Position, FloatPort Volume, FloatPort PlaybackSpeed, BoolPort Is2D, PlayAudioAtPositionData config)
        {
            Node node = new Node()
            {Name = "Play Audio At Position", Type = "9b26c819-856c-4678-a3dc-db070ba492cc", InputCount = 6};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Audio, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Volume, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, PlaybackSpeed, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, Is2D, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.PlayAudioAtPositionData = config;
            return;
        }

        public static void PlayerAddRole(PlayerPort Target, StringPort Value)
        {
            Node node = new Node()
            {Name = "Player Add Role", Type = "7b725036-4996-441d-ac54-91ac2c23d6b3", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort PlayerAwardXP(PlayerPort Player, IntPort Amount, AlternativeExec<BoolPort> OnAwardComplete)
        {
            Node node = new Node()
            {Name = "Player Award XP", Type = "beb93f31-9a12-4b47-a9cc-961febb623aa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Amount, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnAwardComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static QuaternionPort PlayerBodyOrientation(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Body Orientation", Type = "d5f0503f-eee6-4a2a-811d-33ead7122bd3", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerBodyPosition(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Body Position", Type = "5de67799-3301-48d8-ac08-0b371b418962", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PlayerClearCurrentSubtitle(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Clear Current Subtitle", Type = "a542e800-22c8-4e0b-ac4d-ea712875a5f8", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerDefinitionBoard()
        {
            Node node = new Node()
            {Name = "Player Definition Board", Type = "4c9e7840-0721-4d1c-b334-167f79d3bf40", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static BoolPort PlayerEquipInventoryItem(PlayerPort Player, InventoryItemPort InventoryItem, EquipmentSlotPort InventoryEquipmentSlot, AlternativeExec<BoolPort> OnEquipComplete)
        {
            Node node = new Node()
            {Name = "Player Equip Inventory Item", Type = "ad1dc480-3932-482f-9609-ab0b01f234e8", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, InventoryEquipmentSlot, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnEquipComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static ListPort<PlayerPort> PlayerGetAllWithTag(StringPort Tag)
        {
            Node node = new Node()
            {Name = "Player Get All with Tag", Type = "8286a047-19a2-4ad0-bdec-833f35adf4f2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetCanTeleport(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Can Teleport", Type = "52fcfdc0-5f37-4c4c-892a-f61ba6ebf686", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static CostumePort PlayerGetCostume(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Costume", Type = "c6778471-488c-4bc8-8e05-c322b91e1180", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new CostumePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetCrouchInputEnabled(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Crouch Input Enabled", Type = "974059d8-f0cf-4b33-a467-c3403d56f2a6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetDominantHandIsRight(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Dominant Hand Is Right", Type = "2cc92be4-ca23-4148-88d6-71cfb9b7fd58", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetEquipmentSlotIsEnabled(PlayerPort Player, EquipmentSlotPort EquipmentSlot)
        {
            Node node = new Node()
            {Name = "Player Get Equipment Slot Is Enabled", Type = "c8470b28-0f2c-4a60-80e5-e6dac582a0ab", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, EquipmentSlot, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (RecRoomObjectPort DominantHandObject, RecRoomObjectPort OffHandObject, RecRoomObjectPort LeftHipHolsterObject, RecRoomObjectPort RightHipHolsterObject, RecRoomObjectPort ShoulderHolsterObject) PlayerGetEquippedObjects(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Equipped Objects", Type = "f0827a17-7d21-45ba-b302-c2b068bd50ca", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 3}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 4}});
            return output_ports;
        }

        public static PlayerPort PlayerGetFirstWithTag(StringPort Tag)
        {
            Node node = new Node()
            {Name = "Player Get First with Tag", Type = "48364320-cb02-41d8-9d8f-50291131dad2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetForceManualSprint(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Force Manual Sprint", Type = "7b099bfd-965c-4d78-9e7b-59114bf64dbb", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetForceVirtualHeightMode(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Force Virtual Height Mode", Type = "1f8923fe-d4dd-45c8-8161-b69bb4a1704e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetForceVRWalk(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Force VR Walk", Type = "5711c16e-3550-4d35-a549-cfa704b9d556", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsAuthorityOf(PlayerPort Target, RecRoomObjectPort Object)
        {
            Node node = new Node()
            {Name = "Player Get Is Authority Of", Type = "c35fe6fe-d231-4ee5-80ff-9e69f24eb29e", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsClambering(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Is Clambering", Type = "fea61975-90b0-4187-b28a-b732a14834c0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsCrouching(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Is Crouching", Type = "97a006a4-10fc-43ab-b222-e1d9b3d09d61", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort IsGrounded, FloatPort TimeSinceLastGrounded, RecRoomObjectPort SurfaceObject, Vector3Port SurfaceNormal) PlayerGetIsGrounded(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Is Grounded", Type = "4db35e9d-3a1d-4823-a011-7f94e028a3e7", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new Vector3Port{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static (BoolPort IsJumpingOrFalling, RecRoomObjectPort ContactSurface) PlayerGetIsJumpingOrFalling(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Is Jumping Or Falling", Type = "a474eca1-e820-4249-a314-fbc0ae223a5f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort PlayerGetIsLocal(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Get Is Local", Type = "4646dbed-e616-470e-8e0c-eb446b91838b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsProne(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Is Prone", Type = "781ccd7b-a399-47dd-a174-fab918cea059", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsRoomOwner(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Get Is Room Owner", Type = "58c5cab7-ddf7-4de8-86c8-25f3d3c19d98", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsSliding(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Is Sliding", Type = "a6bf14e7-5f67-415e-b1c0-67adc223b01e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsSprinting(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Is Sprinting", Type = "52544269-fc72-4b7e-97eb-23d9b84af1e2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetJumpHeight(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Jump Height", Type = "42dbf319-8d57-41d2-921f-f3f707e6ad81", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetJumpInputEnabled(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Jump Input Enabled", Type = "e6ec527a-be2e-438d-84f4-f60c4785206c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetNormalizedSteeringSpeed(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Normalized Steering Speed", Type = "1eb70662-4a75-4120-9713-11dbbeedc740", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetRadioChannel(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Radio Channel", Type = "be2f38d2-c6cb-4d9a-b74d-0a664c216a7b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetRoomIndex(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Room Index", Type = "7683e201-29d3-44d4-abb4-d75ef9233faa", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetRoomLevel(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Room Level", Type = "475ba7d2-6031-4ea7-b7b8-11028971e466", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static SeatPort PlayerGetSeat(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Seat", Type = "47038300-2f6d-4876-bbb7-7c2e64fd9364", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new SeatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetSprintInputEnabled(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Sprint Input Enabled", Type = "0b931a90-b24c-4be8-8503-efeea655c660", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetSprintSpeed(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Sprint Speed", Type = "345866e8-5b3b-41f1-84b7-e357643be3c7", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerGetSteeringDirection(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Steering Direction", Type = "119718a6-adb8-40b3-9e0c-b48dd5cb9ff3", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetTeleportDelay(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Teleport Delay", Type = "aa63bd19-b0a1-441f-8d69-71591d9007b9", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetTeleportDistance(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Teleport Distance", Type = "08b53553-0368-4de9-bb59-57a4e2fdb2b2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetTimeZone(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Time Zone", Type = "2d675f16-502a-489e-8fed-161935f32c04", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetVoiceRolloffDistance(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Voice Rolloff Distance", Type = "7dd7ea91-2600-4002-804d-3a88d8b3b8a5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetWalkInputEnabled(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Walk Input Enabled", Type = "1b936400-5666-42f6-8d7e-8f0957efebce", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetWalkSpeed(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get Walk Speed", Type = "9decb308-a5c1-41d6-8d68-cfc96d894505", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetXP(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Get XP", Type = "88a12c40-5a38-4304-be23-36f769c2a4b8", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerHasRole(PlayerPort Target, StringPort Value)
        {
            Node node = new Node()
            {Name = "Player Has Role", Type = "9b39ed47-e9a5-4f04-b4cd-80f5bbaff2f7", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadForwardVector(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Head Forward Vector", Type = "9fb898a5-f5f2-4d62-be3d-31381279d1d3", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerHeadHeight(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Head Height", Type = "6278538c-5ea9-4515-ba00-ffc4d5b99c3b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort PlayerHeadOrientation(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Head Orientation", Type = "21ee2f55-0414-4fd6-a915-a2577832d6bd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadPosition(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Head Position", Type = "2f3571aa-53bf-4f52-b8fe-d1c42eda6081", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadUpVector(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Head Up Vector", Type = "5adbfc46-75b1-4b2f-b072-5531ebb0246b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadVelocity(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Head Velocity", Type = "6577e6e8-8039-4843-aba1-993eb6967326", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerIsHoldingMakerPen(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Is Holding Maker Pen", Type = "554060d7-5631-40a0-8d75-5dca5b2b910b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerIsInParty(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Is In Party", Type = "7e6788b0-08a1-4c76-b591-9c8460bcf925", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerIsRoomHost(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Is Room Host", Type = "6f4324c5-4c7a-4243-97d0-58f027996534", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerIsRoomMod(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Is Room Mod", Type = "8f9b0921-a92b-4d01-a4d5-a8d2e6fc6ca0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandFingerDirection(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Finger Direction", Type = "6b5c4b0b-be26-4055-b26f-1e5f061c63ca", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandPosition(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Position", Type = "619b3bc8-bcb9-4812-86f5-f6442cdbb557", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort PlayerLeftHandRotation(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Rotation", Type = "17e61429-059f-4b29-b8b8-f0bf3179f580", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandThumbDirection(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Thumb Direction", Type = "fc2a0141-4997-422c-bdd3-f7ecd7d4c996", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandVelocity(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Velocity", Type = "2607a0fe-f200-4f29-83ae-446db4b8e8ce", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerOwnsInventoryItem(PlayerPort Player, InventoryItemPort InventoryItem, AlternativeExec<BoolPort> Complete)
        {
            Node node = new Node()
            {Name = "Player Owns Inventory Item", Type = "68cc97a7-440a-450a-bf7f-b25091629c32", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort PlayerOwnsRoomKey(PlayerPort Player, RoomKeyPort RoomKey, AlternativeExec<BoolPort> OnPlayerOwnsRoomKeyComplete)
        {
            Node node = new Node()
            {Name = "Player Owns Room Key", Type = "e61558a9-0ce4-4dba-ac87-b16e61bcdb23", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, RoomKey, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnPlayerOwnsRoomKeyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex) PlayerPromptMultipleChoice(PlayerPort Player, StringPort PromptTitle, StringPort PromptBody, ListPort<StringPort> AnswerChoices, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex)> OnPromptComplete)
        {
            Node node = new Node()
            {Name = "Player Prompt Multiple Choice", Type = "d376a3c7-67c2-4607-a124-e2b93dc256d8", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, PromptTitle, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, PromptBody, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, AnswerChoices, new Port{Node = node, Index = 4});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new PlayerPort{Port = new Port{Node = node, Index = 3}}, new StringPort{Port = new Port{Node = node, Index = 4}}, new IntPort{Port = new Port{Node = node, Index = 5}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnPromptComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void PlayerReferenceBoard()
        {
            Node node = new Node()
            {Name = "Player Reference Board", Type = "e6b15a3d-e584-44d9-9a82-23dab32e2c24", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static void PlayerRemoveRole(PlayerPort Target, StringPort Value)
        {
            Node node = new Node()
            {Name = "Player Remove Role", Type = "89981fe2-2e27-4b92-b8c2-c0159b62bccc", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerResetNameColor(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Player Reset Name Color", Type = "d492a0c8-2f55-428f-8960-60f15258681e", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static Vector3Port PlayerRightHandFingerDirection(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Finger Direction", Type = "646ff790-c930-4565-ae38-99a798271a50", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerRightHandPosition(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Position", Type = "e9d3330d-c290-41d5-aa37-cc5e43198836", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort PlayerRightHandRotation(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Rotation", Type = "0afab661-0870-42bb-9256-891f1a876b3b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerRightHandThumbDirection(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Thumb Direction", Type = "86e8581c-ddf9-4302-a06f-c451b5055a98", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerRightHandVelocity(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Velocity", Type = "aba06411-9c8c-477a-bc7f-76ab5605c85d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PlayerSetCanTeleport(PlayerPort Player, BoolPort CanTeleport)
        {
            Node node = new Node()
            {Name = "Player Set Can Teleport", Type = "de2df219-9d85-4778-a9a3-255d912596a2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, CanTeleport, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetCrouchInputEnabled(PlayerPort Player, BoolPort CrouchInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Crouch Input Enabled", Type = "046d23a2-5f34-40dc-a586-008c7bc391f0", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, CrouchInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetEquipmentSlotIsEnabled(PlayerPort Player, EquipmentSlotPort EquipmentSlot, BoolPort IsEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Equipment Slot Is Enabled", Type = "8557a9c5-2656-4245-ae4e-c04bb6de0cd8", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, EquipmentSlot, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, IsEnabled, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetForceManualSprint(PlayerPort Player, BoolPort ForceManualSprint)
        {
            Node node = new Node()
            {Name = "Player Set Force Manual Sprint", Type = "25663723-fc4c-454f-9d33-d28120163245", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ForceManualSprint, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetForceVirtualHeightMode(PlayerPort Player, BoolPort ForceVirtualHeightMode)
        {
            Node node = new Node()
            {Name = "Player Set Force Virtual Height Mode", Type = "2d73b51d-5703-4a1a-bb80-acc05161e3dc", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ForceVirtualHeightMode, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetForceVRWalk(PlayerPort Player, BoolPort ForceVRWalk)
        {
            Node node = new Node()
            {Name = "Player Set Force VR Walk", Type = "c4fa9164-e585-4813-93f4-b31da5635a8b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ForceVRWalk, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetJumpHeight(PlayerPort Player, FloatPort JumpHeight)
        {
            Node node = new Node()
            {Name = "Player Set Jump Height", Type = "5dae4912-b714-4cbe-91ab-c736b517d0d6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, JumpHeight, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetJumpInputEnabled(PlayerPort Player, BoolPort JumpInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Jump Input Enabled", Type = "d837f992-bcc3-4571-b402-c39a5378e1ee", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, JumpInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetNameColor(PlayerPort Player, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Player Set Name Color", Type = "19d7fe7e-99e9-444c-8e4f-12c5237abe90", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetRadioChannel(PlayerPort Player, IntPort Channel)
        {
            Node node = new Node()
            {Name = "Player Set Radio Channel", Type = "231d05ba-8577-4d1e-888d-115e657dd525", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Channel, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetSprintInputEnabled(PlayerPort Player, BoolPort SprintInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Sprint Input Enabled", Type = "68b971bc-30af-44d0-ad2f-50a5bbad1f5e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, SprintInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetSprintSpeed(PlayerPort Player, FloatPort SprintSpeed)
        {
            Node node = new Node()
            {Name = "Player Set Sprint Speed", Type = "23e9efca-876b-4a5f-b813-770b9e77fbd4", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, SprintSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetTeleportDelay(PlayerPort Player, FloatPort TeleportDelay)
        {
            Node node = new Node()
            {Name = "Player Set Teleport Delay", Type = "0d489d96-de0f-47c0-a629-ab7b22f18a21", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, TeleportDelay, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetTeleportDistance(PlayerPort Player, FloatPort TeleportDistance)
        {
            Node node = new Node()
            {Name = "Player Set Teleport Distance", Type = "39d0f90b-dc6c-4b8d-b103-f3f01228d08e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, TeleportDistance, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetVoiceRolloffDistance(PlayerPort Player, FloatPort VoiceRolloffDistance)
        {
            Node node = new Node()
            {Name = "Player Set Voice Rolloff Distance", Type = "7fd128dd-189b-4454-9824-5f482f8f5ce6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, VoiceRolloffDistance, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetWalkInputEnabled(PlayerPort Player, BoolPort WalkInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Walk Input Enabled", Type = "e5f60f37-b6f5-45a8-9ef6-ea38dd908531", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, WalkInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetWalkSpeed(PlayerPort Player, FloatPort WalkSpeed)
        {
            Node node = new Node()
            {Name = "Player Set Walk Speed", Type = "56454777-7c0d-4d1c-acd2-112d7c7a0e31", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, WalkSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerShowSubtitle(PlayerPort Player, StringPort Subtitle, FloatPort Duration, IntPort Priority)
        {
            Node node = new Node()
            {Name = "Player Show Subtitle", Type = "abaae687-e943-4534-bb78-2c8d7e17c425", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Subtitle, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Priority, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort Result, IntPort SecondsUntilEnabled) PlayerSubscribesToRoomOwner(PlayerPort Target)
        {
            Node node = new Node()
            {Name = "Player Subscribes To Room Owner", Type = "7e321d9b-4500-4917-9361-a32e1463401c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort PlayerUnequipFromSlot(PlayerPort Player, EquipmentSlotPort EquipmentSlot, AlternativeExec<BoolPort> OnUnequipComplete)
        {
            Node node = new Node()
            {Name = "Player Unequip From Slot", Type = "a672e48b-931e-48d3-ba8c-34b3f415919c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, EquipmentSlot, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnUnequipComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort PlayerUnequipInventoryItem(PlayerPort Player, InventoryItemPort InventoryItem, AlternativeExec<BoolPort> OnUnequipComplete)
        {
            Node node = new Node()
            {Name = "Player Unequip Inventory Item", Type = "944c8ed8-a0da-465d-95f8-e1b7a850ef2d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, InventoryItem, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnUnequipComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static PlayerPort PlayerVariable(PlayerPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Player Variable", Type = "ea61960b-3a53-426e-b87c-f0e94dd2c3da", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static PlayerPort PlayerVariableDeprecated(PlayerPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Player Variable", Type = "1094590a-ca33-4ca0-8e6b-66d784f4b5d7", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static PlayerWorldUIPort PlayerWorldUI(PlayerWorldUIData config)
        {
            Node node = new Node()
            {Name = "Player World UI", Type = "ff2d1f81-d76c-456f-acf0-af1861822681", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new PlayerWorldUIPort{Port = new Port{Node = node, Index = 0}};
            node.PlayerWorldUIData = config;
            return output_ports;
        }

        public static void PlayHandleHaptics(TriggerHandlePort Handle, IntPort Duration, FloatPort Intensity)
        {
            Node node = new Node()
            {Name = "Play Handle Haptics", Type = "da6980ad-92eb-4ce8-a643-291e2bf82bc7", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Handle, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Intensity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayHandleHaptics(GunHandlePort Handle, IntPort Duration, FloatPort Intensity)
        {
            Node node = new Node()
            {Name = "Play Handle Haptics", Type = "da6980ad-92eb-4ce8-a643-291e2bf82bc7", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Handle, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Intensity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayHandleHaptics(SwingHandlePort Handle, IntPort Duration, FloatPort Intensity)
        {
            Node node = new Node()
            {Name = "Play Handle Haptics", Type = "da6980ad-92eb-4ce8-a643-291e2bf82bc7", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Handle, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Intensity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static IntPort Power(IntPort Value)
        {
            Node node = new Node()
            {Name = "Power", Type = "288d4e89-ebed-41ed-a522-4c79bd48471a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Power(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Power", Type = "288d4e89-ebed-41ed-a522-4c79bd48471a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PrintTextToScreen(TextScreenPort Target, StringPort Text, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Print Text To Screen", Type = "5f9f8c85-8aaa-4c9d-9d9d-4c952053b623", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Text, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherFireProjectile(ProjectileLauncherPort Target, Vector3Port Direction)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Fire Projectile", Type = "27e235ea-7305-4f3e-a426-04a887cbde6d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static PlayerPort ProjectileLauncherGetFiringPlayer(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Firing Player", Type = "9bc9def7-d7c3-4248-ba1c-35116f013768", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ProjectileLauncherGetHandDamage(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Hand Damage", Type = "ed1f109d-bc85-4e4b-8f15-d33363aed7dd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ProjectileLauncherGetHeadDamage(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Head Damage", Type = "7aa59933-c380-428e-aca9-2de2875cb38d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort ProjectileLauncherGetProjectileColor(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Color", Type = "29005ae6-2611-4ed3-9bed-e256749b487a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ProjectileLauncherGetProjectileCount(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Count", Type = "25f4df63-828a-482b-89e5-96e357575dfe", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ProjectileLauncherGetProjectileLifetime(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Lifetime", Type = "7af08c60-bd52-4733-9a9a-c22317f28738", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ProjectileLauncherGetProjectileSpeed(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Speed", Type = "1803843e-4e3b-4422-ada9-5f8959337ee5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ProjectileLauncherGetProjectileSpread(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Spread", Type = "7c6fcbd2-d306-4824-ae11-73e2c133a7fb", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ProjectileLauncherGetRecRoomObjectDamage(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Rec Room Object Damage", Type = "630823d4-c27f-493e-81a3-ae482448403d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ProjectileLauncherGetTorsoDamage(ProjectileLauncherPort Target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Torso Damage", Type = "0da5a0be-9c01-4fcc-83a4-a660971c8644", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ProjectileLauncherSetFiringPlayer(ProjectileLauncherPort Target, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Firing Player", Type = "ebff1459-5eb7-456c-a753-f8267d45f79d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetHandDamage(ProjectileLauncherPort Target, IntPort Damage)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Hand Damage", Type = "3dd1fa27-a800-4d05-8b47-16ad48311135", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetHeadDamage(ProjectileLauncherPort Target, IntPort Damage)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Head Damage", Type = "f9eeb1b4-5721-4d30-82d4-3bfdea0b8617", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileColor(ProjectileLauncherPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Color", Type = "3a253a6e-fc0f-4ae2-b669-0418c09fc553", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileCount(ProjectileLauncherPort Target, IntPort Count)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Count", Type = "28132c36-99ac-405d-807e-aeacbc37a3f1", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Count, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileLifetime(ProjectileLauncherPort Target, FloatPort Lifetime)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Lifetime", Type = "b91d3e3d-7c6b-4fba-9505-66c8afd0245d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Lifetime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileSpeed(ProjectileLauncherPort Target, FloatPort Speed)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Speed", Type = "01cf75ba-b056-4226-b646-84fee1b7c9aa", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileSpread(ProjectileLauncherPort Target, FloatPort Spread)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Spread", Type = "c01cee87-a81e-4cdb-84c5-d443cfe53bce", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Spread, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetRecRoomObjectDamage(ProjectileLauncherPort Target, IntPort Damage)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Rec Room Object Damage", Type = "1fcd6f83-b403-426d-8ded-7064e8790b2d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetTorsoDamage(ProjectileLauncherPort Target, IntPort Damage)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Torso Damage", Type = "531dc709-286e-429c-9d51-537a63d74f76", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort PromptLocalPlayer(StringPort PromptTitle, StringPort Prompt, AlternativeExec<StringPort> Complete, AlternativeExec<StringPort> Failed)
        {
            Node node = new Node()
            {Name = "Prompt Local Player", Type = "46e6b40e-2416-4078-b7dc-a0ecc2c2aa20", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, PromptTitle, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Prompt, new Port{Node = node, Index = 2});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Complete(output_ports);
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 3});
            Failed(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static QuaternionPort QuaternionCreate(FloatPort X, FloatPort Y, FloatPort Z, FloatPort W)
        {
            Node node = new Node()
            {Name = "Quaternion Create", Type = "cff17d2a-4333-41da-81ac-2825f25bf819", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, X, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Y, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Z, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, W, new Port{Node = node, Index = 3});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateAngleAxis(FloatPort Angle, Vector3Port Axis)
        {
            Node node = new Node()
            {Name = "Quaternion Create Angle Axis", Type = "d9096fb3-50c6-42f9-93bb-fc6df63d86a8", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Angle, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Axis, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateEulerAngles(Vector3Port Angles)
        {
            Node node = new Node()
            {Name = "Quaternion Create Euler Angles", Type = "e320278c-13f0-4fe3-b838-7e671bdd9b49", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Angles, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateFromTo(Vector3Port From, Vector3Port To)
        {
            Node node = new Node()
            {Name = "Quaternion Create From To", Type = "1069c5de-c7e3-40e0-bd90-52135873b36d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, From, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, To, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateLook(Vector3Port Forward, Vector3Port Upwards)
        {
            Node node = new Node()
            {Name = "Quaternion Create Look", Type = "b28f369d-6758-4afc-80e2-8f09ea1df125", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Forward, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Upwards, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort QuaternionDot(QuaternionPort Lhs, QuaternionPort Rhs)
        {
            Node node = new Node()
            {Name = "Quaternion Dot", Type = "268d931e-172b-48e8-8eb8-8ec2a9614f0d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Lhs, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Rhs, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port QuaternionEulerAngles(QuaternionPort Value)
        {
            Node node = new Node()
            {Name = "Quaternion Euler Angles", Type = "81048ea5-2778-4816-99c5-1c50faad8a87", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Angle, Vector3Port Axis) QuaternionGetAngleAxis(QuaternionPort Quaternion)
        {
            Node node = new Node()
            {Name = "Quaternion Get Angle Axis", Type = "b415c3ce-5f9f-472b-8d70-daeb728b7c2d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Quaternion, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new Vector3Port{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static QuaternionPort QuaternionInverse(QuaternionPort Value)
        {
            Node node = new Node()
            {Name = "Quaternion Inverse", Type = "2097bef3-9ed1-4601-ab5d-f620654bd1c4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionNormalize(QuaternionPort Value)
        {
            Node node = new Node()
            {Name = "Quaternion Normalize", Type = "8157b896-fce8-45fc-957a-4407f0d6c42a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionRotateTowards(QuaternionPort From, QuaternionPort To, FloatPort MaxDegreesDelta)
        {
            Node node = new Node()
            {Name = "Quaternion Rotate Towards", Type = "edfe7cbb-6973-4489-9b7a-75746243dd6d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, From, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, To, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxDegreesDelta, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort X, FloatPort Y, FloatPort Z, FloatPort W) QuaternionSplit(QuaternionPort Quaternion)
        {
            Node node = new Node()
            {Name = "Quaternion Split", Type = "1d2a37e1-428e-4385-bc96-4ad5adff0a05", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Quaternion, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static QuaternionPort QuaternionVariable(QuaternionPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Quaternion Variable", Type = "18a980ff-9a46-472c-b658-96bf42eb61c2", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort RandomFloat(FloatPort Min, FloatPort Max)
        {
            Node node = new Node()
            {Name = "Random Float", Type = "4ecbf247-ab14-4f9e-8094-e40a45d283e6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Max, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static T RandomFromList<T>(ListPort<T> List)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Random From List", Type = "d253cef6-dd99-4357-b98a-e09a0c23bad7", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, List, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static T RandomFromListDeprecated<T>(ListPort<T> List)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Random From List (Deprecated)", Type = "0b18cef3-0ea5-4e3c-a0d5-c460f03dbe8c", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, List, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static IntPort RandomInt(IntPort Min, IntPort Max)
        {
            Node node = new Node()
            {Name = "Random Int", Type = "fb2645f0-4042-4ef1-b988-af2f80e651ec", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Max, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static (BoolPort Hit, PlayerPort Player, RecRoomObjectPort Object, FloatPort Distance, Vector3Port HitPosition, Vector3Port SurfaceNormal) Raycast(Vector3Port StartPosition, Vector3Port Direction, FloatPort MaxDistance, RaycastData config)
        {
            Node node = new Node()
            {Name = "Raycast", Type = "af203a1f-f3c9-479b-86f0-72224b094179", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StartPosition, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxDistance, new Port{Node = node, Index = 2});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}}, new Vector3Port{Port = new Port{Node = node, Index = 4}}, new Vector3Port{Port = new Port{Node = node, Index = 5}});
            node.RaycastData = config;
            return output_ports;
        }

        public static BoolPort RecalculateRoomAuthority()
        {
            Node node = new Node()
            {Name = "Recalculate Room Authority", Type = "d5df73b6-4b92-4867-ab3a-5d308876598b", InputCount = 1};
            Context.current.Nodes.Add(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> RecRoomObjectGetAllWithTag(StringPort Tag)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get All with Tag", Type = "02d69553-ae96-4c2d-8477-59ada6a66783", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort RecRoomObjectGetAuthority(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Authority", Type = "9e51fcdc-87b4-4eee-a7b1-8d6f86a5fa6b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecRoomObjectPort RecRoomObjectGetFirstWithTag(StringPort Tag)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get First with Tag", Type = "43ff2d3c-c3aa-45bc-a7b7-01587c8a61f6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort IsHeld, PlayerPort HolderPlayer) RecRoomObjectGetHolderPlayer(RecRoomObjectPort Object)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Holder Player", Type = "cd10a7ff-0c35-4b46-abfb-8e2f18397ad5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort RecRoomObjectGetIsLocalPlayerAuthority(RecRoomObjectPort Target)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Is Local Player Authority", Type = "b0497de0-3dd3-470d-a421-8f0d321bfc3e", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (PlayerPort Player, BoolPort CurrentlyHeldOrEquipped) RecRoomObjectGetLastHoldingOrEquippingPlayer(RecRoomObjectPort Object)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Last Holding Or Equipping Player", Type = "a76a9898-4add-4765-9f5b-f366b586e51c", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 0});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static void RecRoomObjectReset(RecRoomObjectPort Object)
        {
            Node node = new Node()
            {Name = "Rec Room Object Reset", Type = "6ba175cf-493a-4790-b916-57259f94cd98", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RecRoomObjectSetAuthority(RecRoomObjectPort Target, PlayerPort Authority)
        {
            Node node = new Node()
            {Name = "Rec Room Object Set Authority", Type = "191f8009-5a2e-4da4-8817-980842a08d48", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Authority, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RecRoomObjectPort RecRoomObjectVariable(RecRoomObjectPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Rec Room Object Variable", Type = "7077d139-9876-495e-9756-58150fef9f3b", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void RemovePlayerFromRadioChannel(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Remove Player From Radio Channel", Type = "eb605a54-315e-495e-b051-8d113c32ed7c", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTag(PlayerPort Target, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Remove Tag", Type = "207c6721-b242-4dc2-857d-ebd1ff7c8624", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTag(RecRoomObjectPort Target, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Remove Tag", Type = "207c6721-b242-4dc2-857d-ebd1ff7c8624", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTags(PlayerPort Target, ListPort<StringPort> Tags)
        {
            Node node = new Node()
            {Name = "Remove Tags", Type = "fb368814-daaf-475f-ae08-1d01b9d63b8e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTags(RecRoomObjectPort Target, ListPort<StringPort> Tags)
        {
            Node node = new Node()
            {Name = "Remove Tags", Type = "fb368814-daaf-475f-ae08-1d01b9d63b8e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RequestVelocitySetOverDuration(PlayerPort Object, FloatPort Multiplier, Vector3Port Velocity, FloatPort Duration)
        {
            Node node = new Node()
            {Name = "Request Velocity Set Over Duration", Type = "73a26510-9160-4e68-93dc-da60aa68a514", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RequestVelocitySetOverDuration(RecRoomObjectPort Object, FloatPort Multiplier, Vector3Port Velocity, FloatPort Duration)
        {
            Node node = new Node()
            {Name = "Request Velocity Set Over Duration", Type = "73a26510-9160-4e68-93dc-da60aa68a514", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static T Reroute<T>(T Port0)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Reroute", Type = "f8db4ba2-7380-49a0-a0ba-bcdca11fec96", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 0});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ResetPlayerWorldUI(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Reset Player World UI", Type = "962aaeb2-b80a-4b5a-9b21-de0917c35a1c", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ResetRoom()
        {
            Node node = new Node()
            {Name = "Reset Room", Type = "e921b08d-10c2-4be4-86fe-b8c7155cb97b", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, null);
            return;
        }

        public static BoolPort Respawn(PlayerPort Target, Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort Respawn(PlayerPort Target, Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort Respawn(RecRoomObjectPort Target, Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort Respawn(RecRoomObjectPort Target, Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void RespawnDeprecated(PlayerPort Target, Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RespawnDeprecated(PlayerPort Target, Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RespawnDeprecated(RecRoomObjectPort Target, Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RespawnDeprecated(RecRoomObjectPort Target, Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RespawnPointAddAvoidRole(PlayerSpawnPointV2Port SpawnPoint, StringPort Role)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Avoid Role", Type = "e9b24d3a-7abc-4e97-99f9-e3d31d2c885c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void RespawnPointAddAvoidTag(PlayerSpawnPointV2Port SpawnPoint, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Avoid Tag", Type = "82122e0c-d393-4735-a7ad-2217b09eb73c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort RespawnPointAddSpawnRole(PlayerSpawnPointV2Port SpawnPoint, StringPort Role)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Spawn Role", Type = "83bc6208-b272-46a7-add2-46178a71a9e6", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void RespawnPointAddSpawnTag(PlayerSpawnPointV2Port SpawnPoint, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Spawn Tag", Type = "3e936c68-9fbf-4ace-89a3-68156859db19", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort RespawnPointGetActive(PlayerSpawnPointV2Port Target)
        {
            Node node = new Node()
            {Name = "Respawn Point Get Active", Type = "49bab5c6-d519-4af5-a5ee-466798e3e8bd", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RespawnPointRemoveAvoidRole(PlayerSpawnPointV2Port SpawnPoint, StringPort Role)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Avoid Role", Type = "c1405f55-4980-40cb-9607-daf53073a79e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRemoveAvoidTag(PlayerSpawnPointV2Port SpawnPoint, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Avoid Tag", Type = "1a6a4fc0-6e4a-4768-abea-a71c10ffa612", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRemoveSpawnRole(PlayerSpawnPointV2Port SpawnPoint, StringPort Role)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Spawn Role", Type = "22b02578-a084-42ac-a27f-72a1fcb7cd63", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRemoveSpawnTag(PlayerSpawnPointV2Port SpawnPoint, StringPort Tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Spawn Tag", Type = "99cb7522-13a7-4aec-9166-dc0497057bbb", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRespawnPlayer(PlayerPort Player, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn Point Respawn Player", Type = "350cda38-d7c5-4319-bb15-a06f49bbb0b9", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRespawnPlayerAtRespawnPoint(PlayerSpawnPointV2Port SpawnPoint, PlayerPort Player, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn Point Respawn Player At Respawn Point", Type = "c52419da-019e-4104-95e3-0f0adfa8ebf2", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SpawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, ClearVelocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, UseRezEffects, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointSetActive(PlayerSpawnPointV2Port Target, BoolPort Active)
        {
            Node node = new Node()
            {Name = "Respawn Point Set Active", Type = "bf3275dc-686f-4a63-87b7-5422a70cc4d2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Active, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RewardPort Reward()
        {
            Node node = new Node()
            {Name = "Reward", Type = "7f246785-9c56-4896-a1f4-f011988dcd32", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new RewardPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort RGBToColor(FloatPort Red, FloatPort Green, FloatPort Blue)
        {
            Node node = new Node()
            {Name = "RGB To Color", Type = "c38b908d-df40-4bd0-bf8b-38afe6cbe9e2", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Red, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Green, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Blue, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort RoomBackgroundObjectsModify(BackgroundObjectsPort BackgroundObjectsConstant, AlternativeExec<BoolPort> BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Modify", Type = "f16741ca-778f-44de-99e6-6a948c7aecfb", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, BackgroundObjectsConstant, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomBackgroundObjectsReset(AlternativeExec BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Reset", Type = "56c10ead-6198-4b13-b6de-d1df9080341b", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static RoomCurrencyPort RoomCurrencyConstant(RoomCurrencyData config)
        {
            Node node = new Node()
            {Name = "Room Currency Constant", Type = "7e843432-afde-41c1-9bc1-194112d91226", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new RoomCurrencyPort{Port = new Port{Node = node, Index = 0}};
            node.RoomCurrencyData = config;
            return output_ports;
        }

        public static BoolPort RoomFogModify(FogPort FogConstant, AlternativeExec<BoolPort> BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Modify", Type = "471f7cf9-a4e4-4162-a6e9-d594b6ec28ef", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, FogConstant, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomFogReset(AlternativeExec BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Reset", Type = "2dd67fbd-eb84-4810-bfa7-55836139f8a2", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RoomGetMatchmakingState()
        {
            Node node = new Node()
            {Name = "Room Get Matchmaking State", Type = "2d358c91-9000-4851-ad37-65759a135ab7", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort RoomIndexGetPlayer(IntPort RoomIndex)
        {
            Node node = new Node()
            {Name = "Room Index Get Player", Type = "61e30876-2f28-4ba6-9d70-dfa5cc2af1cc", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, RoomIndex, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RoomKeyPort RoomKeyConstant(RoomKeyData config)
        {
            Node node = new Node()
            {Name = "Room Key Constant", Type = "b9b000ca-eb3d-4b9f-9f45-0fd64045f63d", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new RoomKeyPort{Port = new Port{Node = node, Index = 0}};
            node.RoomKeyData = config;
            return output_ports;
        }

        public static RoomLevelHUDPort RoomLevelHUD()
        {
            Node node = new Node()
            {Name = "Room Level HUD", Type = "0681e9de-2f79-4f6a-9d8a-06140507760c", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new RoomLevelHUDPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RoomLevels(AnyPort Levels)
        {
            Node node = new Node()
            {Name = "Room Levels", Type = "a63f19b0-206f-4079-a5b0-4622619200a1", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Levels, new Port{Node = node, Index = 0});
            return;
        }

        public static RoomOfferPort RoomOfferConstant()
        {
            Node node = new Node()
            {Name = "Room Offer Constant", Type = "1d129345-7897-4a9c-b364-6aaf35333164", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new RoomOfferPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort RoomSetMatchmakingState(BoolPort MatchmakingPermitted, AlternativeExec<BoolPort> OnMatchmakingStateSet)
        {
            Node node = new Node()
            {Name = "Room Set Matchmaking State", Type = "be4decd2-56a0-46af-8e96-091261946fd9", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, MatchmakingPermitted, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            OnMatchmakingStateSet(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort RoomSkydomeModify(SkydomePort SkydomeConstant, AlternativeExec<BoolPort> BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Modify", Type = "511e85c5-a359-49f1-a83c-a0550e98fe8e", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SkydomeConstant, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomSkydomeReset(AlternativeExec BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Reset", Type = "b17f7045-6fa5-4fc5-84d5-def4f78d4f45", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RoomSunModify(SunPort SunConstant, SunDirectionPort SunDirection, AlternativeExec<BoolPort> BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Modify", Type = "884408a8-5884-41e4-9399-1b0ef5d353e0", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, SunConstant, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, SunDirection, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomSunReset(AlternativeExec BlendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Reset", Type = "b38f186d-67b3-44a1-8a95-120123ddb182", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            BlendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static FloatPort Root(FloatPort Value, FloatPort Root)
        {
            Node node = new Node()
            {Name = "Root", Type = "8b96e472-2b19-4265-aade-2c6202358d86", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Root, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port RotateVector(QuaternionPort Rotation, Vector3Port Point)
        {
            Node node = new Node()
            {Name = "Rotate Vector", Type = "02c4048a-5f67-47ea-9f00-692f51c66e65", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Point, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetRotation(RotatorPort Target)
        {
            Node node = new Node()
            {Name = "Rotator Get Rotation", Type = "30fe0829-2f08-4bd2-b4b1-9a41764e5a76", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetRotationAcceleration(RotatorPort Target)
        {
            Node node = new Node()
            {Name = "Rotator Get Rotation Acceleration", Type = "2d96da47-4d37-4463-a3bd-8f8cd2ab0c58", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetRotationSpeed(RotatorPort Target)
        {
            Node node = new Node()
            {Name = "Rotator Get Rotation Speed", Type = "be834de9-91cb-4588-8988-3a6abfd56573", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetTargetRotation(RotatorPort Target)
        {
            Node node = new Node()
            {Name = "Rotator Get Target Rotation", Type = "117b8c83-5ada-4665-a0c6-2c6ffdec98b9", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RotatorSetRotation(RotatorPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Rotator Set Rotation", Type = "07ae26b8-e0d7-49c0-bb2c-25d66d31fe3c", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RotatorSetRotationAcceleration(RotatorPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Rotator Set Rotation Acceleration", Type = "db29fd41-9fb5-4c2a-8c72-c8d327b0f23f", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RotatorSetRotationSpeed(RotatorPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Rotator Set Rotation Speed", Type = "9d0e3cf5-581d-4fb5-8346-c9e7d9877b3f", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RotatorSetTargetRotation(RotatorPort Target, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Rotator Set Target Rotation", Type = "0f9da436-0752-422d-8323-fa445a9ca06b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Round(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Round", Type = "c6cfe49a-4ffb-4714-9564-8ddda0300676", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort RoundToInt(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Round to Int", Type = "0d2a4771-0694-4b84-8e07-2080c26aae22", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static AudioPort SampleAudioConstant()
        {
            Node node = new Node()
            {Name = "Sample Audio Constant", Type = "2cb45825-f385-414f-9a65-2425963fa720", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort SeatGetLockPlayersIn(SeatPort Target)
        {
            Node node = new Node()
            {Name = "Seat Get Lock Players In", Type = "e46a3c37-7d53-4d4c-9484-48b0ac0694c4", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort SeatGetLockPlayersOut(SeatPort Target)
        {
            Node node = new Node()
            {Name = "Seat Get Lock Players Out", Type = "e0214877-5f0a-46a2-8278-580f2fd293e0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort SeatGetSeatedPlayer(SeatPort Target)
        {
            Node node = new Node()
            {Name = "Seat Get Seated Player", Type = "7fc01b3a-3f44-4cf1-ad2d-d5898fb35f4d", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void SeatSetLockPlayersIn(SeatPort Target, BoolPort LockPlayersIn)
        {
            Node node = new Node()
            {Name = "Seat Set Lock Players In", Type = "af071963-a0df-422e-8372-e561336921db", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LockPlayersIn, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SeatSetLockPlayersOut(SeatPort Target, BoolPort LockPlayersOut)
        {
            Node node = new Node()
            {Name = "Seat Set Lock Players Out", Type = "face947c-8ac1-4d8e-8318-e7ec98bf466d", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, LockPlayersOut, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SeatSetSeatedPlayer(SeatPort Target, PlayerPort Player, AlternativeExec Fail)
        {
            Node node = new Node()
            {Name = "Seat Set Seated Player", Type = "d652ebe5-1367-44ed-a352-1e5ab84c32b0", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Fail();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void SeatUnseatPlayer(SeatPort Target)
        {
            Node node = new Node()
            {Name = "Seat Unseat Player", Type = "70b682f5-5744-4a6a-beaa-a9dcd40066b6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort Self()
        {
            Node node = new Node()
            {Name = "Self", Type = "3d7d40d6-885a-4fa5-bbaa-b19057291ddb", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void Sequence<T>(AlternativeExec _2)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Sequence", Type = "9e2ac049-e68e-4689-a288-bef8a62da316", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            _2();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void SetCameraShake(PlayerPort Player, FloatPort Intensity, FloatPort Duration)
        {
            Node node = new Node()
            {Name = "Set Camera Shake", Type = "a4bf7bb6-6dd9-4b34-85ab-2aaa324647e4", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Intensity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetGameHUDElementColor(HUDConstantPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Set Game HUD Element Color", Type = "47f61ea8-aab2-4b0e-8d59-351c0047d853", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetGameHUDElementLabel(HUDConstantPort Target, StringPort Label)
        {
            Node node = new Node()
            {Name = "Set Game HUD Element Label", Type = "04fb09fa-5be2-491b-9d16-d5b21083f528", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Label, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetGameHUDElementLabelEnabled(HUDConstantPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Set Game HUD Element Label Enabled", Type = "2231d8fa-fa63-4952-8ba4-a8258ffb2f9b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetGameHUDElementMaxValue(HUDConstantPort Target, IntPort Value)
        {
            Node node = new Node()
            {Name = "Set Game HUD Element Max Value", Type = "f258d689-3341-4383-a8f1-73ab7b2f37a1", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetGameHUDElementValue(HUDConstantPort Target, IntPort Value)
        {
            Node node = new Node()
            {Name = "Set Game HUD Element Value", Type = "61efbc78-9ddf-42bb-814a-3758a34f5faf", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetGameHUDElementValueTextEnabled(HUDConstantPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Set Game HUD Element Value Text Enabled", Type = "a980fe11-65d0-4ae2-bd4c-6405cfc01ce0", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementEnabled(HUDConstantPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Set HUD Element Enabled", Type = "64ebc8ff-a7d0-47b3-b00b-3cd7e5927978", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerVignette(PlayerPort Player, FloatPort Time, ColorPort Color, FloatPort Intensity)
        {
            Node node = new Node()
            {Name = "Set Player Vignette", Type = "fee486b2-823f-4110-b33a-241adb59b634", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Time, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Intensity, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarColor(PlayerPort Player, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Color", Type = "859086b7-8a86-4dde-b8cb-c3a361d13fe3", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarEnabled(PlayerPort Player, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Enabled", Type = "03c280c2-5f80-4ba9-8966-6c5d11da84a9", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarMaxValue(PlayerPort Player, IntPort Value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Max Value", Type = "eafda897-0a2a-41a7-bce4-7f7b62c7e887", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarValue(PlayerPort Player, IntPort Value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Value", Type = "7d868adf-0fe5-4a21-9dda-f04c4a6f77af", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarColor(PlayerPort Player, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Color", Type = "a94540da-0639-4e88-adf6-c90f6612fe05", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarEnabled(PlayerPort Player, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Enabled", Type = "fce830ef-b17c-4564-a74d-c819b0fedcf7", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarMaxValue(PlayerPort Player, IntPort Value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Max Value", Type = "38fa1fe5-e9cf-45b4-8fa7-0633064e4cc3", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarValue(PlayerPort Player, IntPort Value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Value", Type = "358e29c5-2aa5-4c9a-a9bf-7a18e1fc3148", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUITextColor(PlayerPort Player, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Set Player World UI Text Color", Type = "31b7328c-f362-4473-88b9-c49092e97700", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUITextEnabled(PlayerPort Player, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Set Player World UI Text Enabled", Type = "82787e0f-8a9c-4fb1-a087-f24b4461f8c9", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUITextValue(PlayerPort Player, StringPort Value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Text Value", Type = "cd09d0fa-1943-4838-a707-c9a902aff0ae", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort SetPosition(PlayerPort Target, Vector3Port Position)
        {
            Node node = new Node()
            {Name = "Set Position", Type = "6e68ede8-32de-455f-9449-83951b4e4f73", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetPosition(RecRoomObjectPort Target, Vector3Port Position)
        {
            Node node = new Node()
            {Name = "Set Position", Type = "6e68ede8-32de-455f-9449-83951b4e4f73", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void SetPositionDeprecated(PlayerPort Target, Vector3Port Position, AlternativeExec Failed)
        {
            Node node = new Node()
            {Name = "Set Position (Deprecated)", Type = "ff1c2a15-4099-4aaa-afe3-c217b2fca15b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void SetPositionDeprecated(RecRoomObjectPort Target, Vector3Port Position, AlternativeExec Failed)
        {
            Node node = new Node()
            {Name = "Set Position (Deprecated)", Type = "ff1c2a15-4099-4aaa-afe3-c217b2fca15b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            Failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort SetRotation(PlayerPort Target, Vector3Port Rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotation(PlayerPort Target, QuaternionPort Rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotation(RecRoomObjectPort Target, Vector3Port Rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotation(RecRoomObjectPort Target, QuaternionPort Rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(PlayerPort Target, Vector3Port Position, Vector3Port Rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(PlayerPort Target, Vector3Port Position, QuaternionPort Rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(RecRoomObjectPort Target, Vector3Port Position, Vector3Port Rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(RecRoomObjectPort Target, Vector3Port Position, QuaternionPort Rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static AudioPort SFXConstant(SFXConstantData config)
        {
            Node node = new Node()
            {Name = "SFX Constant", Type = "d65a4666-5036-436b-ad42-a20aafa2174d", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            node.SFXConstantData = config;
            return output_ports;
        }

        public static BoolPort SFXGetIsPlaying(SFXPort Target)
        {
            Node node = new Node()
            {Name = "SFX Get Is Playing", Type = "a0a17fe1-bdb0-4687-81de-141ce97710ed", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort SFXGetVolume(SFXPort Target)
        {
            Node node = new Node()
            {Name = "SFX Get Volume", Type = "aaf39143-c5dc-47cd-ad85-c659c3035cab", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void SFXPlay(SFXPort Target)
        {
            Node node = new Node()
            {Name = "SFX Play", Type = "5f8991bb-d1b8-4c74-a54a-86e7033b53a0", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SFXSetVolume(SFXPort Target, IntPort Value)
        {
            Node node = new Node()
            {Name = "SFX Set Volume", Type = "d2df4993-d858-4df1-aca2-fc0e7f479668", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SFXStop(SFXPort Target)
        {
            Node node = new Node()
            {Name = "SFX Stop", Type = "3ad57fda-1fab-4b00-81b3-71d61af37c65", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowNotification<T>(PlayerPort Player, StringPort Value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Show Notification", Type = "61bc2310-69f5-4dfa-b43c-12ae98dd05ab", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePrompt(RoomKeyPort InRoomPurchasable, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "7a8d9550-41fa-42a3-8d52-0fc7e6ac3213", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePrompt(ConsumablePort InRoomPurchasable, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "7a8d9550-41fa-42a3-8d52-0fc7e6ac3213", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePrompt(RoomCurrencyPort InRoomPurchasable, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "7a8d9550-41fa-42a3-8d52-0fc7e6ac3213", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePromptV2(RoomOfferPort InRoomPurchasable, PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "53a17ff2-a6fe-4b69-adb0-1b1fdf5a7de0", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, InRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowRewardNotification(PlayerPort Player, RewardPort Reward, FloatPort Duration)
        {
            Node node = new Node()
            {Name = "Show Reward Notification", Type = "3d713e71-2729-4819-819c-bcbe6fb8d400", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Reward, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowRewardNotification(PlayerPort Player, ListPort<RewardPort> Reward, FloatPort Duration)
        {
            Node node = new Node()
            {Name = "Show Reward Notification", Type = "3d713e71-2729-4819-819c-bcbe6fb8d400", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Reward, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Duration, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Sin(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Sin", Type = "ea824326-5061-411d-980c-30031511c821", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static SkydomePort SkydomeConstant()
        {
            Node node = new Node()
            {Name = "Skydome Constant", Type = "bff88a1e-4888-4e03-a1f4-804864a2f177", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new SkydomePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort Slerp(QuaternionPort Start, QuaternionPort End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Slerp", Type = "8d5f0586-1ecf-42ba-a34f-c6ccbb0eadb9", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Slerp(Vector3Port Start, Vector3Port End, FloatPort Progress)
        {
            Node node = new Node()
            {Name = "Slerp", Type = "8d5f0586-1ecf-42ba-a34f-c6ccbb0eadb9", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, End, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Progress, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Result, FloatPort ResultVelocity) SmoothDamp(FloatPort Current, FloatPort Target, FloatPort CurrentVelocity, FloatPort SmoothTime, FloatPort MaxSpeed, FloatPort DeltaTime)
        {
            Node node = new Node()
            {Name = "Smooth Damp", Type = "830600a6-ec28-46b0-9354-13e0a1061232", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Current, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, CurrentVelocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SmoothTime, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, MaxSpeed, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, DeltaTime, new Port{Node = node, Index = 6});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static (Vector3Port Result, Vector3Port ResultVelocity) SmoothDamp(Vector3Port Current, Vector3Port Target, Vector3Port CurrentVelocity, FloatPort SmoothTime, FloatPort MaxSpeed, FloatPort DeltaTime)
        {
            Node node = new Node()
            {Name = "Smooth Damp", Type = "830600a6-ec28-46b0-9354-13e0a1061232", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Current, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, CurrentVelocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SmoothTime, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, MaxSpeed, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, DeltaTime, new Port{Node = node, Index = 6});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 1}}, new Vector3Port{Port = new Port{Node = node, Index = 2}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void SpawnerInternalStartSpawning(RecRoomObjectPort Spawner, IntPort Amountofobjectstospawn, FloatPort Timebetweenspawns, Vector3Port SpawnPosition)
        {
            Node node = new Node()
            {Name = "Spawner Internal Start Spawning", Type = "fb6a63b1-3f55-4dcf-9bf0-6ef82e3296d5", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Spawner, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Amountofobjectstospawn, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Timebetweenspawns, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, SpawnPosition, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SpawnerReset(RecRoomObjectPort Port0)
        {
            Node node = new Node()
            {Name = "Spawner Reset", Type = "6a669e6e-4ebf-434c-9c23-d2b769d49b47", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort Hit, PlayerPort Player, RecRoomObjectPort Object, FloatPort Distance, Vector3Port HitPosition, Vector3Port SurfaceNormal) Spherecast(Vector3Port StartPosition, FloatPort Radius, Vector3Port Direction, FloatPort MaxDistance, RaycastData config)
        {
            Node node = new Node()
            {Name = "Spherecast", Type = "0ea23792-e987-459e-8cd7-c0c60f667e08", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StartPosition, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Radius, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, MaxDistance, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}}, new Vector3Port{Port = new Port{Node = node, Index = 4}}, new Vector3Port{Port = new Port{Node = node, Index = 5}});
            node.RaycastData = config;
            return output_ports;
        }

        public static void State()
        {
            Node node = new Node()
            {Name = "State", Type = "54fe9649-9512-4135-a6e5-9eea7d877fa5", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static StatePort StateConstant()
        {
            Node node = new Node()
            {Name = "State Constant", Type = "bf4f0801-2e6b-4e4b-a2df-a005fe622087", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new StatePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void StateMachine()
        {
            Node node = new Node()
            {Name = "State Machine", Type = "2963631f-bcd1-4712-9613-d304bc997248", InputCount = 0};
            Context.current.Nodes.Add(node);
            return;
        }

        public static void StopCameraShake(PlayerPort Player)
        {
            Node node = new Node()
            {Name = "Stop Camera Shake", Type = "a06b802b-bb80-4f66-937e-3a764a419c4d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static StringPort StringConcat(StringPort Separator, StringPort Value)
        {
            Node node = new Node()
            {Name = "String Concat", Type = "73ed7ea2-cead-405a-b39c-1fec4bfd4236", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Separator, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort StringContains(StringPort String, StringPort Sequence)
        {
            Node node = new Node()
            {Name = "String Contains", Type = "aa24edab-c707-4cff-8c73-07e479b4cd07", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Sequence, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringFormat(StringPort Format, StringPort Value)
        {
            Node node = new Node()
            {Name = "String Format", Type = "77afc9dd-baa9-4312-b8b8-7ef479c840e6", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Format, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort StringIndexOf(StringPort String, StringPort Substring)
        {
            Node node = new Node()
            {Name = "String Index Of", Type = "1af21999-38f8-4231-9de9-26b43f47fe0d", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Substring, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort StringLength(StringPort String)
        {
            Node node = new Node()
            {Name = "String Length", Type = "dcde9345-00f2-41fb-9a2d-5a938f39bfb5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringReplace(StringPort String, StringPort Pattern, StringPort Replacement)
        {
            Node node = new Node()
            {Name = "String Replace", Type = "b394650e-7673-40a3-8b9e-3aa8eaa2a77e", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Pattern, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Replacement, new Port{Node = node, Index = 2});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> StringSplit(StringPort String, StringPort Divider)
        {
            Node node = new Node()
            {Name = "String Split", Type = "ad169649-1050-48c5-a540-f03a2059bcdb", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Divider, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> StringSplitAtIndex(StringPort String, IntPort Index)
        {
            Node node = new Node()
            {Name = "String Split At Index", Type = "6b92c345-e6bc-40d9-aae9-4754e634777c", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Index, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> StringSplitWhitespace(StringPort String)
        {
            Node node = new Node()
            {Name = "String Split Whitespace", Type = "7695ff77-5b9d-4a41-a894-6602b98f289f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringSubstring(StringPort String, IntPort Index, IntPort Length)
        {
            Node node = new Node()
            {Name = "String Substring", Type = "226fafe2-1ea8-4ae8-861e-ae4b1bd10bfe", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Index, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Length, new Port{Node = node, Index = 2});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringToLower(StringPort String)
        {
            Node node = new Node()
            {Name = "String To Lower", Type = "678f6d33-1e94-4be6-b959-0212c1a2207f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringToUpper(StringPort String)
        {
            Node node = new Node()
            {Name = "String To Upper", Type = "8f5995c7-5af0-4064-9cb7-2b80d75d157f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringTrim(StringPort String)
        {
            Node node = new Node()
            {Name = "String Trim", Type = "e6f056ee-cf6d-4696-b338-31418275af16", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, String, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringVariable(StringPort Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "string Variable", Type = "66b6ea20-9a00-4f80-9636-2cfb676b3965", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static AudioPort StudioAudioConstant()
        {
            Node node = new Node()
            {Name = "Studio Audio Constant", Type = "7dc47ad4-9b51-4cb3-8e40-6b76f1243e6f", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void StudioEventSender(StudioObjectPort StudioObject, StringPort Event)
        {
            Node node = new Node()
            {Name = "Studio Event Sender", Type = "e4f23e24-182a-4dac-b6ab-8baf94081762", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderBool(StudioObjectPort StudioObject, StringPort Event, BoolPort Value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - Bool", Type = "84efd7b3-fddc-4f50-b0b6-c728bef04f52", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderFloat(StudioObjectPort StudioObject, StringPort Event, FloatPort Value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - Float", Type = "441f3853-e402-4dfa-9d50-1453d243cb6d", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderInt(StudioObjectPort StudioObject, StringPort Event, IntPort Value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - Int", Type = "1a29d0ac-0372-4a8a-84cd-9df9af8920a1", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderString(StudioObjectPort StudioObject, StringPort Event, StringPort Value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String", Type = "6bc4210c-dc16-4686-90bf-f95da3338b74", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringBool(StudioObjectPort StudioObject, StringPort Event, StringPort Value0, BoolPort Value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, Bool", Type = "91f2d5db-f6c6-4ef0-b134-056fa57c953d", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringFloat(StudioObjectPort StudioObject, StringPort Event, StringPort Value0, FloatPort Value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, Float", Type = "e394ced1-c594-4750-a4c1-6e861cfe57c0", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringInt(StudioObjectPort StudioObject, StringPort Event, StringPort Value0, IntPort Value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, Int", Type = "dabac52b-26ef-422d-bded-e9234449b989", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringString(StudioObjectPort StudioObject, StringPort Event, StringPort Value0, StringPort Value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, String", Type = "06225a58-e343-4cec-b93b-949f69a430c7", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static void StudioFunction(StudioFunctionData config)
        {
            Node node = new Node()
            {Name = "Studio Function", Type = "43847b33-9777-474f-be65-caccfffc8579", InputCount = 1};
            Context.current.Nodes.Add(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.StudioFunctionData = config;
            return;
        }

        public static BoolPort StudioObjectGetPropertyBool(StudioObjectPort StudioObject, StringPort Property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Bool", Type = "7ab38485-8d7c-4c98-b8f3-55a11d4ab741", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Property, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort StudioObjectGetPropertyFloat(StudioObjectPort StudioObject, StringPort Property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Float", Type = "0dda9345-0211-4757-8fea-03e05fac89c3", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Property, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort StudioObjectGetPropertyInt(StudioObjectPort StudioObject, StringPort Property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Int", Type = "4467dc43-b07c-41fc-9e43-21ebf8f86554", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Property, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StudioObjectGetPropertyString(StudioObjectPort StudioObject, StringPort Property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - String", Type = "a0708f14-89b6-4ef7-97eb-38359a57422f", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, StudioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Property, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Subtract(IntPort Value)
        {
            Node node = new Node()
            {Name = "Subtract", Type = "1fbb364c-1af0-44bb-a82b-905caeb6819a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Subtract(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Subtract", Type = "1fbb364c-1af0-44bb-a82b-905caeb6819a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Subtract(Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Subtract", Type = "1fbb364c-1af0-44bb-a82b-905caeb6819a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static SunPort SunConstant()
        {
            Node node = new Node()
            {Name = "Sun Constant", Type = "26062297-4aab-4fd4-bfb8-95fbf64f6bb7", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new SunPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort SwingHandleGetIsSwinging(SwingHandlePort Target)
        {
            Node node = new Node()
            {Name = "Swing Handle Get Is Swinging", Type = "cdebca62-2e6c-4353-8691-d1daae868f5f", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Tan(FloatPort Value)
        {
            Node node = new Node()
            {Name = "Tan", Type = "13dbbd78-11c0-4b4f-9098-1ef59e584324", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort TextGetColor(TextPort Target)
        {
            Node node = new Node()
            {Name = "Text Get Color", Type = "2b28277e-29a1-4b97-b151-2f23ff28c4c2", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort TextGetText(TextPort Target)
        {
            Node node = new Node()
            {Name = "Text Get Text", Type = "3e8fbb88-3179-4a4c-9f8f-d9c2db35b9b5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TextSetColor(TextPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Text Set Color", Type = "0bfaa337-46a1-472f-beac-12faa21867d4", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TextSetColorId(TextPort Target, IntPort Color)
        {
            Node node = new Node()
            {Name = "Text Set Color Id", Type = "20b2528d-96a9-4be8-9782-aa75959f5232", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TextSetMaterial(TextPort Target, IntPort Material)
        {
            Node node = new Node()
            {Name = "Text Set Material", Type = "ef6fcf56-1b3f-42bc-af50-019ff0a9cfc5", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Material, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TextSetText(TextPort Target, StringPort Text)
        {
            Node node = new Node()
            {Name = "Text Set Text", Type = "c941f3a3-d3f6-49cc-a6a4-b7a4e95fd173", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Text, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort TimeGetPreciseSeconds()
        {
            Node node = new Node()
            {Name = "Time Get Precise Seconds", Type = "8722445f-e552-4d4a-bced-8afa63bbf70b", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort TimeGetUniversalSeconds()
        {
            Node node = new Node()
            {Name = "Time Get Universal Seconds", Type = "bc3059d8-b613-4e91-ac7f-4c3566e01dc2", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort Year, IntPort Month, IntPort Day, IntPort Hour, IntPort Minute, IntPort Second) TimeGetUniversalTime()
        {
            Node node = new Node()
            {Name = "Time Get Universal Time", Type = "1b220886-d851-474c-a79e-0a18d0893ee9", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}}, new IntPort{Port = new Port{Node = node, Index = 4}}, new IntPort{Port = new Port{Node = node, Index = 5}});
            return output_ports;
        }

        public static IntPort TimeGetUnsyncedUniversalSeconds()
        {
            Node node = new Node()
            {Name = "Time Get Unsynced Universal Seconds", Type = "d46f6fdc-480c-41e6-9a27-87fadb0ab0fc", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort Year, IntPort Month, IntPort Day, IntPort Hour, IntPort Minute, IntPort Second) TimeGetUnsyncedUniversalTime()
        {
            Node node = new Node()
            {Name = "Time Get Unsynced Universal Time", Type = "f33e3fb6-79f1-43da-93c1-553d022b9f37", InputCount = 0};
            Context.current.Nodes.Add(node);
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}}, new IntPort{Port = new Port{Node = node, Index = 4}}, new IntPort{Port = new Port{Node = node, Index = 5}});
            return output_ports;
        }

        public static CombatantPort ToCombatant(AIPort PlayerorAI)
        {
            Node node = new Node()
            {Name = "To Combatant", Type = "75a3a9c2-da17-4762-b87b-1735b44af659", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, PlayerorAI, new Port{Node = node, Index = 0});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static CombatantPort ToCombatant(PlayerPort PlayerorAI)
        {
            Node node = new Node()
            {Name = "To Combatant", Type = "75a3a9c2-da17-4762-b87b-1735b44af659", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, PlayerorAI, new Port{Node = node, Index = 0});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ToggleButtonGetIsPressed(ToggleButtonPort Target)
        {
            Node node = new Node()
            {Name = "Toggle Button Get Is Pressed", Type = "f8a9cb84-dcb1-4a12-ae29-4d7711e14506", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ToggleButtonSetIsPressed(ToggleButtonPort Target, BoolPort Value)
        {
            Node node = new Node()
            {Name = "Toggle Button Set Is Pressed", Type = "fdfb3857-3d13-4d66-9a05-f88586e9f821", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RecRoomObjectPort ToRecRoomObject<T>(T Target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "To Rec Room Object", Type = "315a494e-84cc-4e3c-acff-389bb932b5d0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ToString<T>(T Value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "To String", Type = "bddc8e4e-b496-48ee-8e25-5b9fe8e1c6c9", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ToStringDeprecated<T>(T Value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "To String", Type = "74e81edb-84bd-4e52-b2f3-a73a62a6b3aa", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort IsTouchActive, Vector3Port TouchPosition, Vector3Port WorldPosition) TouchpadComponentGetActiveTouch(TouchpadPort Target)
        {
            Node node = new Node()
            {Name = "Touchpad Component Get Active Touch", Type = "b83d2e2f-61e8-4490-8a81-d38c88fff8d1", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new Vector3Port{Port = new Port{Node = node, Index = 1}}, new Vector3Port{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static StringPort TouchpadComponentGetInteractionLabel(TouchpadPort Target)
        {
            Node node = new Node()
            {Name = "Touchpad Component Get Interaction Label", Type = "32aa1ef2-a230-430b-9809-19c114b1fe44", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort TouchpadComponentGetIsEnabled(TouchpadPort Target)
        {
            Node node = new Node()
            {Name = "Touchpad Component Get Is Enabled", Type = "64ca9ac0-04a8-4460-afe5-64a927f1ca4a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TouchpadComponentSetInteractionLabel(TouchpadPort Target, StringPort Label)
        {
            Node node = new Node()
            {Name = "Touchpad Component Set Interaction Label", Type = "41643ef3-6003-43d5-9bc7-d520e7aa5fcf", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Label, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TouchpadComponentSetIsEnabled(TouchpadPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Touchpad Component Set Is Enabled", Type = "1f27359f-71ca-4827-ab17-5acbdb027837", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ColorPort TrailGetColor(MotionTrailPort Target)
        {
            Node node = new Node()
            {Name = "Trail Get Color", Type = "f8c16cc7-ceaf-471a-b196-5d46ec7ab72a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort TrailGetEnabled(MotionTrailPort Target)
        {
            Node node = new Node()
            {Name = "Trail Get Enabled", Type = "f3e39f47-1835-4d09-8e19-d3e9d661990b", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort TrailGetLifetime(MotionTrailPort Target)
        {
            Node node = new Node()
            {Name = "Trail Get Lifetime", Type = "0f069b0b-6f70-4386-9c7f-1343661e8df6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort TrailGetOpacity(MotionTrailPort Target)
        {
            Node node = new Node()
            {Name = "Trail Get Opacity", Type = "6dcc7a44-0163-4058-97a9-1ef7f482a3d5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TrailSetColor(MotionTrailPort Target, ColorPort Color)
        {
            Node node = new Node()
            {Name = "Trail Set Color", Type = "d326ebc4-1653-4c1d-886c-c1bd4c06db86", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TrailSetEnabled(MotionTrailPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Trail Set Enabled", Type = "0bf0dcf8-0731-40d4-883d-288862c98aed", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TrailSetLifetime(MotionTrailPort Target, FloatPort Lifetime)
        {
            Node node = new Node()
            {Name = "Trail Set Lifetime", Type = "eb69e7ac-e579-463c-9da9-643e639cf333", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Lifetime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TrailSetOpacity(MotionTrailPort Target, FloatPort MaxOpacity)
        {
            Node node = new Node()
            {Name = "Trail Set Opacity", Type = "bb79cf12-6d38-4691-a004-c2b3ad963374", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxOpacity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort TriggerHandleGetControlPrompt(TriggerHandlePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Handle Get Control Prompt", Type = "8ea2fd23-02c2-4055-ab39-68acd0b6ce67", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort TriggerHandleGetPrimaryActionHeld(TriggerHandlePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Handle Get Primary Action Held", Type = "b309c032-1bcd-4ca1-83cf-b8871e65fb16", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TriggerHandleSetControlPrompt(TriggerHandlePort Target, StringPort ControlPrompt)
        {
            Node node = new Node()
            {Name = "Trigger Handle Set Control Prompt", Type = "f4bc9ad9-6050-4c89-b33d-3c780b357d95", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, ControlPrompt, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort TriggerVolumeGetFilterRole(TriggerVolumePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Filter Role", Type = "b49c4e16-93c5-45c3-b457-fb960c661bc5", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> TriggerVolumeGetFilterTags(TriggerVolumePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Filter Tags", Type = "8f42f9b7-87fb-4f4b-9160-a45baf269650", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort TriggerVolumeGetObjectCount(TriggerVolumePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Object Count", Type = "338c7e0a-fa55-49e1-91e8-1609d00f1fd0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> TriggerVolumeGetObjects(TriggerVolumePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Objects", Type = "530932a7-8781-4b09-a945-b33af6675809", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort TriggerVolumeGetPlayerCount(TriggerVolumePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Player Count", Type = "4cbe661b-7053-4c19-9ccf-1600c7a41016", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> TriggerVolumeGetPlayers(TriggerVolumePort Target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Players", Type = "4c23af85-e05c-4be7-a708-c2f0cc67ebec", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TriggerVolumeSetFilterRole(TriggerVolumePort Target, StringPort Value)
        {
            Node node = new Node()
            {Name = "Trigger Volume Set Filter Role", Type = "55cfecf9-2623-4aad-948c-6ca89f11911b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TriggerVolumeSetFilterTags(TriggerVolumePort Target, ListPort<StringPort> Value)
        {
            Node node = new Node()
            {Name = "Trigger Volume Set Filter Tags", Type = "6668fd38-076e-4d03-b9a1-02eca5edd0b7", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort UnequipFromPlayer(PlayerPort Player, RecRoomObjectPort Object)
        {
            Node node = new Node()
            {Name = "Unequip From Player", Type = "cb633ba9-ae99-43ae-b848-ffcea0b44a4a", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> UnequipFromSlots(PlayerPort Player, BoolPort DominantHand, BoolPort OffHand, BoolPort LeftHipHolster, BoolPort RightHipHolster, BoolPort ShoulderHolster)
        {
            Node node = new Node()
            {Name = "Unequip from Slots", Type = "13a06844-ab37-41d6-9358-0383cf3c35d7", InputCount = 7};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, DominantHand, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, OffHand, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, LeftHipHolster, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, RightHipHolster, new Port{Node = node, Index = 5});
            node.ConnectInputPort(Context.current, ShoulderHolster, new Port{Node = node, Index = 6});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort UnequipObject(RecRoomObjectPort Object)
        {
            Node node = new Node()
            {Name = "Unequip Object", Type = "df6cdb0c-24d7-447d-b29b-3979e51fb865", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Object, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static T ValueIntegerSwitch<T>(IntPort Match, T Default)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Value Integer Switch", Type = "be534038-473e-40ad-b4e2-abd38a76711b", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Match, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Default, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static T ValueStringSwitch<T>(StringPort Match, T Default)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Value String Switch", Type = "2c9dcd54-dd65-498e-8a13-50c221448358", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Match, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Default, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3ClampMagnitude(Vector3Port Vector, FloatPort MaxLength)
        {
            Node node = new Node()
            {Name = "Vector3 Clamp Magnitude", Type = "c12ba6c4-51f6-478c-96a7-b989dbe6df80", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Vector, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, MaxLength, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3ClosestPointOnPlane(Vector3Port Position, Vector3Port PlanePosition, Vector3Port PlaneNormal)
        {
            Node node = new Node()
            {Name = "Vector3 Closest Point On Plane", Type = "abb84e7e-c879-4744-8f29-5392f975d8a0", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Position, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, PlanePosition, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, PlaneNormal, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Create(FloatPort X, FloatPort Y, FloatPort Z)
        {
            Node node = new Node()
            {Name = "Vector3 Create", Type = "814e9337-7542-4851-9da0-c73885ab0b4f", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, X, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Y, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Z, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Cross(Vector3Port Lhs, Vector3Port Rhs)
        {
            Node node = new Node()
            {Name = "Vector3 Cross", Type = "6bd92538-6889-41f3-b819-9511e6f81944", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Lhs, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Rhs, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Vector3Dot(Vector3Port Lhs, Vector3Port Rhs)
        {
            Node node = new Node()
            {Name = "Vector3 Dot", Type = "498c4e25-f73b-49a6-912e-ae148ed50dca", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Lhs, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Rhs, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Inverse(Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Vector3 Inverse", Type = "429fc835-d971-48fd-a030-d8f7d5a96437", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3InverseTransform(Vector3Port WorldPoint, Vector3Port WorldOrigin, QuaternionPort WorldOrientation)
        {
            Node node = new Node()
            {Name = "Vector3 Inverse Transform", Type = "97b150f5-7bd0-4649-96d7-fdf0b5e88ffb", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, WorldPoint, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, WorldOrigin, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, WorldOrientation, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3MoveTowards(Vector3Port Current, Vector3Port Target, FloatPort MaxDelta)
        {
            Node node = new Node()
            {Name = "Vector3 Move Towards", Type = "266d90c7-403e-4059-a481-ce3e22d61420", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Current, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, MaxDelta, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Normalize(Vector3Port Value)
        {
            Node node = new Node()
            {Name = "Vector3 Normalize", Type = "92ded211-17d6-4c73-b29c-71323c6a40ee", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Project(Vector3Port Vector, Vector3Port OnNormal)
        {
            Node node = new Node()
            {Name = "Vector3 Project", Type = "11dcd185-ffb5-476e-a469-d0588f36a2f8", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Vector, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, OnNormal, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3ProjectOnPlane(Vector3Port Vector, Vector3Port PlaneNormal)
        {
            Node node = new Node()
            {Name = "Vector3 Project On Plane", Type = "f874d150-7d49-4f10-ac51-50dd9bd29c4f", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Vector, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, PlaneNormal, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Scale(Vector3Port Value, IntPort Scalar)
        {
            Node node = new Node()
            {Name = "Vector3 Scale", Type = "87aa17b1-7760-4b07-8c44-a2d530590597", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Scalar, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Scale(Vector3Port Value, FloatPort Scalar)
        {
            Node node = new Node()
            {Name = "Vector3 Scale", Type = "87aa17b1-7760-4b07-8c44-a2d530590597", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Scalar, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort X, FloatPort Y, FloatPort Z) Vector3Split(Vector3Port Vector3)
        {
            Node node = new Node()
            {Name = "Vector3 Split", Type = "2d677241-61b7-45d2-aec2-4a302e3483a0", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Vector3, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static Vector3Port Vector3Transform(Vector3Port LocalPoint, Vector3Port WorldOrigin, QuaternionPort WorldOrientation)
        {
            Node node = new Node()
            {Name = "Vector3 Transform", Type = "64924217-da3a-4a6f-b84d-e499634d763b", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, LocalPoint, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, WorldOrigin, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, WorldOrientation, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Variable(Vector3Port Port0, VariableData config)
        {
            Node node = new Node()
            {Name = "Vector3 Variable", Type = "fba2accf-44e2-412d-a204-ae3bd04f7dfa", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Port0, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static Vector3Port VectorComponentGetVector(VectorComponentPort Direction, FloatPort Magnitude)
        {
            Node node = new Node()
            {Name = "Vector Component Get Vector", Type = "74ba9189-2880-46fa-b4b0-3c9a7152489e", InputCount = 2};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 0});
            node.ConnectInputPort(Context.current, Magnitude, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort VectorGetMagnitude(Vector3Port Vector3)
        {
            Node node = new Node()
            {Name = "Vector Get Magnitude", Type = "c3b9ba98-6c4a-44c2-9125-043314fba4a6", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Vector3, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void VelocityAdd(PlayerPort Target, FloatPort Speed, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add", Type = "1b5eca75-0e7e-4aff-8adc-c5e043cac29e", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, MaximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityAdd(RecRoomObjectPort Target, FloatPort Speed, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add", Type = "1b5eca75-0e7e-4aff-8adc-c5e043cac29e", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, MaximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityAddNew(PlayerPort Target, FloatPort Multiplier, Vector3Port Velocity, FloatPort MaximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add (New)", Type = "f94206bd-1903-492f-85fc-07f8f756b9f5", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, MaximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityAddNew(RecRoomObjectPort Target, FloatPort Multiplier, Vector3Port Velocity, FloatPort MaximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add (New)", Type = "f94206bd-1903-492f-85fc-07f8f756b9f5", InputCount = 5};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, MaximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityReflect(PlayerPort Target, FloatPort AdditionalSpeed, FloatPort SpeedMultiplier, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Reflect", Type = "f0137efc-b3b7-4217-ba8b-1d2e78d451bd", InputCount = 6};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, AdditionalSpeed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, SpeedMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, MaximumSpeed, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityReflect(RecRoomObjectPort Target, FloatPort AdditionalSpeed, FloatPort SpeedMultiplier, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Reflect", Type = "f0137efc-b3b7-4217-ba8b-1d2e78d451bd", InputCount = 6};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, AdditionalSpeed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, SpeedMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 4});
            node.ConnectInputPort(Context.current, MaximumSpeed, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySet(PlayerPort Target, FloatPort Multiplier, Vector3Port Velocity)
        {
            Node node = new Node()
            {Name = "Velocity Set", Type = "ea00c655-56ff-4406-8d65-b8399e6d0169", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Velocity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySet(RecRoomObjectPort Target, FloatPort Multiplier, Vector3Port Velocity)
        {
            Node node = new Node()
            {Name = "Velocity Set", Type = "ea00c655-56ff-4406-8d65-b8399e6d0169", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Velocity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySetDeprecated(PlayerPort Target, FloatPort Speed, Vector3Port Direction)
        {
            Node node = new Node()
            {Name = "Velocity Set (Deprecated)", Type = "f97c530d-03bf-498c-8854-33e814d2600b", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySetDeprecated(RecRoomObjectPort Target, FloatPort Speed, Vector3Port Direction)
        {
            Node node = new Node()
            {Name = "Velocity Set (Deprecated)", Type = "f97c530d-03bf-498c-8854-33e814d2600b", InputCount = 4};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(Context.current, Direction, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort WelcomeMatGetEnabled(WelcomeMatPort Target)
        {
            Node node = new Node()
            {Name = "Welcome Mat Get Enabled", Type = "d26c3f7a-7204-471b-a0bb-5e52960983f8", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void WelcomeMatSetEnabled(WelcomeMatPort Target, BoolPort Enabled)
        {
            Node node = new Node()
            {Name = "Welcome Mat Set Enabled", Type = "d503f1b3-7c5e-4eba-85ac-b89be2d2360f", InputCount = 3};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(Context.current, Enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort Xor(BoolPort Input)
        {
            Node node = new Node()
            {Name = "Xor", Type = "6db8f573-5300-4aa0-bbfa-b5f01533069a", InputCount = 1};
            Context.current.Nodes.Add(node);
            node.ConnectInputPort(Context.current, Input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }
    }
}