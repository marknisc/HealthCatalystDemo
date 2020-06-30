"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Phone = /** @class */ (function () {
    function Phone() {
    }
    Phone.prototype.toString = function () {
        var numstr = this.Number.toString();
        return this.PhoneType + ": (" + numstr.substring(0, 3) + ")" + numstr.substring(2, 3) + "-" + numstr.substring(5);
    };
    return Phone;
}());
exports.Phone = Phone;
//# sourceMappingURL=Phone.js.map