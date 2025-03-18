'use client';

import { useState } from 'react';
import { DropdownOption } from '@/Interfaces/dropdownOption';
import DropdownSelect from '@/componets/dropdown/dropdown-select';
import NavigationButton from '../navigation-button/navigation-button';
import { useRouter } from 'next/navigation';



interface FamilySelectorProps {
    options: DropdownOption[];
}

export default function FamilySelector({ options }: FamilySelectorProps) {
    const router = useRouter();

    const [selected, setSelected] = useState<DropdownOption | null>(null);

    const handleSelection = (option: DropdownOption | null) => {
        setSelected(option);
    };

    const handleNavigate = () => {
        if (selected) {
            router.push(`/families/${selected.value}`);
        }
    };

    return (
        <>
            <DropdownSelect options={options} selectedOption={selected} onChange={handleSelection}/>
            {selected && <NavigationButton label='Visit the selected family' onClick={handleNavigate} />}
        </>
    );
}