export interface CreateEventRequest {
    name: string;
    date: string;
    capacity: number;
    cost: number;
    attractionIds: string[];
}