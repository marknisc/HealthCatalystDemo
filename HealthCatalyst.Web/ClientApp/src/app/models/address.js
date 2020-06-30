"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Address = /** @class */ (function () {
    function Address() {
    }
    Address.prototype.toString = function () {
        return this.Line1 + "<br/>" + this.City + " " + this.State + " " + this.PostalCode;
    };
    return Address;
}());
exports.Address = Address;
//# sourceMappingURL=address.js.map