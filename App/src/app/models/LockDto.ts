import { LockType } from "./lockType";
import { LockBuildingDto } from "./lockBuildingDto";

export interface LockDto {
    type: LockType;
    name: string;
    serialNumber: string;
    floor: string;
    roomNumber: string;
    description: string;
    searchWeight: number;
    building: LockBuildingDto;
}