using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class ExampleRoom : CircuitBuilder
    {
        EventDefinition<IntPort> testEvent;
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomExample();
            EventCacheExample();
            VariableLoopExample();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void RandomExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            EventReceiver(RoomEvents.Hz30);
                IntPort rand1 = default !;
                rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), () => rand1, (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
                IntPort rand2 = default !;
                rand2 = __VariableDeclaratorExpression<IntPort>("rand2", () => RandomInt(0, 10), () => rand2, (_RRCG_SETTER_VALUE) => rand2 = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(false), () => ChipBuilder.GreaterThan(rand1 + rand2, 10), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("Today's your lucky day");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("Try again next time");
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void EventCacheExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            EventReceiver(RoomEvents.Hz30);
                IntPort rand1 = default !;
                rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), () => rand1, (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
                IntPort sum = default !;
                sum = __VariableDeclaratorExpression<IntPort>("sum", () => (rand1 + 3) + (4 + 5), () => sum, (_RRCG_SETTER_VALUE) => sum = _RRCG_SETTER_VALUE);
                IntPort cached = default !;
                cached = __VariableDeclaratorExpression<IntPort>("cached", () => ChipLib.EventCache<IntPort>(sum), () => cached, (_RRCG_SETTER_VALUE) => cached = _RRCG_SETTER_VALUE);
            PlayerShowSubtitle(GetLocalPlayer(), ToString<IntPort>(cached), 3.0f, 0);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void VariableLoopExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                IntPort intValue = default !;
                intValue = __VariableDeclaratorExpression<IntPort>("intValue", () => testEvent.Receiver(), () => intValue, (_RRCG_SETTER_VALUE) => intValue = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<IntPort> counter = default !;
                counter = __VariableDeclaratorExpression<RRCGBuild.Variable<IntPort>>("counter", () => new Variable<IntPort>(), () => counter, (_RRCG_SETTER_VALUE) => counter = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(true), () => ChipBuilder.LessThan(counter.Value, intValue), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                ChipLib.Log(counter.Value);
                counter.Value++;
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public ExampleRoom()
        {
            testEvent = __VariableDeclaratorExpression<EventDefinition<IntPort>>("testEvent", () => new EventDefinition<IntPort>("intValue"), () => testEvent, (_RRCG_SETTER_VALUE) => testEvent = _RRCG_SETTER_VALUE);
        }
    }
}