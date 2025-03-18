import { DropdownOption } from '@/Interfaces/DropdownOption';
import { FamilyListApiResponse } from '@/Interfaces/familyListApiResponse';
import DropdownSelect from '@/componets/dropdown/dropdown-select';

const apiUrl = 'http://localhost:7006/api/v1/Families';
const clientId = 'client-id-3ff5d097-dd85-463a-bb52-5b51fe97fb51';

export default async function Families() {
    const options: DropdownOption[] = [];
    try {
        const rawResponse = await fetch(apiUrl, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'x-client-id': clientId,
            }
        });
        const response: FamilyListApiResponse = await rawResponse.json();
        if (response && response.families){
            options.push(...response.families.map(item => ({
                label: item.name,
                value: item.id,
            })));
        }

    } catch (error) {
        console.error("Error fetching dropdown options:", error);
    }
    
    return (
        <DropdownSelect options={options}/>
    );
}