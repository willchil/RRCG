using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class DataTables : RRCGBuild.CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.DataTable<RRCGBuild.IntPort, RRCGBuild.FloatPort, RRCGBuild.StringPort> table = default !;
                table = __VariableDeclaratorExpression<RRCGBuild.DataTable<RRCGBuild.IntPort, RRCGBuild.FloatPort, RRCGBuild.StringPort>>("table", () => new RRCGBuild.DataTable<RRCGBuild.IntPort, RRCGBuild.FloatPort, RRCGBuild.StringPort>("Test Table 1", RRCGBuild.DataTablesTestData.GetThreeColumnData(50)), () => table!, (_RRCG_SETTER_VALUE) => table = _RRCG_SETTER_VALUE);
                RRCGBuild.DataTableColumn<RRCGBuild.IntPort> indexColumn = default !;
                indexColumn = __VariableDeclaratorExpression<RRCGBuild.DataTableColumn<RRCGBuild.IntPort>>("indexColumn", () => table.Column0, () => indexColumn!, (_RRCG_SETTER_VALUE) => indexColumn = _RRCG_SETTER_VALUE);
                RRCGBuild.DataTableColumn<RRCGBuild.FloatPort> percentageColumn = default !;
                percentageColumn = __VariableDeclaratorExpression<RRCGBuild.DataTableColumn<RRCGBuild.FloatPort>>("percentageColumn", () => table.Column1, () => percentageColumn!, (_RRCG_SETTER_VALUE) => percentageColumn = _RRCG_SETTER_VALUE);
                RRCGBuild.DataTableColumn<RRCGBuild.StringPort> nameColumn = default !;
                nameColumn = __VariableDeclaratorExpression<RRCGBuild.DataTableColumn<RRCGBuild.StringPort>>("nameColumn", () => table.Column2, () => nameColumn!, (_RRCG_SETTER_VALUE) => nameColumn = _RRCG_SETTER_VALUE);
            // Access column names
            // This is provided as a convenience feature, mainly for existing data tables.
            // Data Tables created like above will give you autogenerated names like column0, etc.
            LogString(__StringInterpolation("Have columns: ", indexColumn.Name, ", ", percentageColumn.Name, ", ", nameColumn.Name));
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), 0, table.RowCount, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("Row ", i, ": ", indexColumn[i], ", ", percentageColumn[i], ", ", nameColumn[i]));
                    RRCGBuild.ChipLib.AwaitDelay();
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            // Test lookup features
            LogString(__StringInterpolation(nameColumn.GetAllRowsContaining("Element 5")));
            LogString(__StringInterpolation(indexColumn.GetFirstRowContaining(25)));
            // Test ReadCell method
            // (Equivalent to the indexer, provided as alternate syntax)
            LogString(__StringInterpolation(percentageColumn.ReadCell(10)));
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}