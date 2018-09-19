
/// <reference path="../coalesce.dependencies.d.ts" />

// Generated by IntelliTect.Coalesce

module ViewModels {
    
    /** External Type FieldWork */
    export class FieldWork {
        public parent: any;
        public parentCollection: any;
        
        // Observables
        public fieldWorkId: KnockoutObservable<number | null> = ko.observable(null);
        public fieldCompletionDateTime: KnockoutObservable<moment.Moment | null> = ko.observable(moment());
        public inspections: KnockoutObservableArray<ViewModels.Inspection> = ko.observableArray([]);
        
        /** 
            Load the object from the DTO.
            @param data: The incoming data object to load.
        */
        public loadFromDto = (data: any) => {
            if (!data) return;
            
            // Load the properties.
            this.fieldWorkId(data.fieldWorkId);
            if (data.fieldCompletionDateTime == null) this.fieldCompletionDateTime(null);
            else if (this.fieldCompletionDateTime() == null || !this.fieldCompletionDateTime()!.isSame(moment(data.fieldCompletionDateTime))) {
                this.fieldCompletionDateTime(moment(data.fieldCompletionDateTime));
            }
            if (data.inspections != null) {
            // Merge the incoming array
                Coalesce.KnockoutUtilities.RebuildArray(this.inspections, data.inspections, null, ViewModels.Inspection, this, true);
            }
            
        };
        
        /** Saves this object into a data transfer object to send to the server. */
        public saveToDto = (): any => {
            var dto: any = {};
            
            dto.fieldWorkId = this.fieldWorkId();
            if (!this.fieldCompletionDateTime()) dto.fieldCompletionDateTime = null;
            else dto.fieldCompletionDateTime = this.fieldCompletionDateTime()!.format('YYYY-MM-DDTHH:mm:ssZZ');
            
            return dto;
        }
        
        constructor(newItem?: any, parent?: any) {
            this.parent = parent;
            
            if (newItem) {
                this.loadFromDto(newItem);
            }
        }
    }
}