using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Optimizer : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            TestNotIfOptimizer();
            TestKnownSingletonChipsOptimizer();
            TestVariableCollapseOptimizer();
            TestAssociativeOperationCollapseOptimizer();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestNotIfOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("TestNotIfOptimizer").Definition();
            entry.Receiver();
            var optimizableBool = ParseBool("true").Result;
            ChipBuilder.If(true, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(!true, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(Not(true), delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            var optimizableButNotDeletable = !ParseBool("true").Result;
            ChipBuilder.If(optimizableButNotDeletable, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipLib.Log(optimizableButNotDeletable);
            ChipBuilder.If(optimizableBool, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(!optimizableBool, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(ChipBuilder.Equals(ParseInt("1").Result, 1), delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(ChipBuilder.Not(ChipBuilder.Equals(ParseInt("1").Result, 1)), delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestKnownSingletonChipsOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("TestKnownSingletonChipsOptimizer").Definition();
            entry.Receiver();
            var floatVar = new Variable<FloatPort>();
            // All these Time Get Precise Seconds nodes
            // will be collapsed into a single node.
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestVariableCollapseOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("TestVariableCollapseOptimiser").Definition();
            entry.Receiver();
            var var0 = new Variable<FloatPort>();
            var var1 = new Variable<FloatPort>();
            var var2 = new Variable<FloatPort>();
            var var3 = new Variable<FloatPort>();
            // All read-only instances of each
            // variable will be collapsed into
            // the "writing" instance.
            var0.Value = RandomFloat(0, 100);
            ChipLib.Log(var0.Value);
            var1.Value = RandomFloat(0, 100);
            ChipLib.Log(var1.Value);
            var2.Value = RandomFloat(0, 100);
            ChipLib.Log(var2.Value);
            var3.Value = RandomFloat(0, 100);
            ChipLib.Log(var3.Value);
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestAssociativeOperationCollapseOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = new EventHelper("TestAssociativeOperationCollapseOptimizer").Definition();
            e.Receiver();
            var variable = new Variable<FloatPort>();
            variable.Value = ChipBuilder.Add(ChipBuilder.Add(ChipBuilder.Add(ChipBuilder.Add(ChipBuilder.Add(variable.Value, 2f), 3f), 4f), 5f), ChipBuilder.Multiply(ChipBuilder.Multiply(ChipBuilder.Multiply(ChipBuilder.Multiply(6f, 7f), 8f), 9f), 10f));
            FloatPort undeletableAdd = ChipBuilder.Add(variable.Value, 5f);
            FloatPort collapsible = ChipBuilder.Add(ChipBuilder.Add(ChipBuilder.Add(ChipBuilder.Add(undeletableAdd, 1f), 2f), 3f), 4f);
            ChipLib.Log(undeletableAdd);
            ChipLib.Log(collapsible);
            var stringPort = Reroute<StringPort>(" ");
            ChipLib.Log(ChipBuilder.Add(ChipBuilder.Add("Hello", stringPort), "World"));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

